
namespace Enterprise.Membership.Pages
{
    using Administration;
    using Administration.Entities;
    using Administration.Repositories;
    using Organization.Entities;
    using Organization.Repositories;
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using Serenity.Web;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Mail;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Security;

    public partial class AccountController : Controller
    {
        [HttpGet]
        public ActionResult SignUp()
        {
            if (UseAdminLTELoginBox)
                return View(MVC.Views.Administration.User.Membership.Account.SignUp.AccountSignUp_AdminLTE);
            else
                return View(MVC.Views.Administration.User.Membership.Account.SignUp.AccountSignUp);
        }

        [HttpPost, JsonFilter]
        public Result<ServiceResponse> SignUp(SignUpRequest request)
        {
            return this.UseConnection("Default", connection =>
            {
                request.CheckNotNull();

                Check.NotNullOrWhiteSpace(request.Email, "email");
                Check.NotNullOrEmpty(request.Password, "password");
                UserRepository.ValidatePassword(request.Email, request.Password, true);
                Check.NotNullOrWhiteSpace(request.FirstName, "firstName");
                Check.NotNullOrWhiteSpace(request.LastName, "lastName");
                Check.NotNull(request.DateOfBirth, "dateOfBirth");

                if (connection.Exists<UserRow>(
                        UserRow.Fields.Username == request.Email |
                        UserRow.Fields.Email == request.Email))
                {
                    throw new ValidationError("EmailInUse", Texts.Validation.EmailInUse);
                }

                using (var uow = new UnitOfWork(connection))
                {
                    string salt = null;
                    var hash = UserRepository.GenerateHash(request.Password, ref salt);
                    var firstName = request.FirstName.TrimToEmpty();
                    var lastName = request.LastName.TrimToEmpty();
                    var dateOfBirth = request.DateOfBirth;
                    var email = request.Email;
                    var username = request.Email;

                    var fld = UserRow.Fields;
                    var newUser = new UserRow
                    {
                        Username = username,
                        Source = "sign",
                        Email = email,
                        PasswordHash = hash,
                        PasswordSalt = salt,
                        IsActive = 0,
                        InsertDate = DateTime.Now,
                        InsertUserId = 1,
                        LastDirectoryUpdate = DateTime.Now
                    };
                    newUser.UserId = (int)connection.InsertAndGetID(newUser);

                    newUser.SetPersonnelRecord(uow, new PersonnelRow
                    {
                        FirstName = request.FirstName,
                        LastName = request.LastName,
                        DateOfBirth = request.DateOfBirth,
                        PersonnelStatus = (long)Constants.PersonnelStatusIds.UNVERIFIED,
                        Gender = Constants.Gender.Undefined
                    });

                    //activation link
                    var token = newUser.GetToken("Activate");

                    var externalUrl = Config.Get<EnvironmentSettings>().SiteExternalUrl ??
                        Request.Url.GetLeftPart(UriPartial.Authority) + VirtualPathUtility.ToAbsolute("~/");

                    var activateLink = UriHelper.Combine(externalUrl, "Account/Activate?t=");
                    activateLink = activateLink + Uri.EscapeDataString(token);

                    var emailModel = new ActivateEmailModel();
                    emailModel.Username = username;
                    emailModel.DisplayName = firstName + " " + lastName;
                    emailModel.ActivateLink = activateLink;

                    var emailSubject = Texts.Forms.Membership.SignUp.ActivateEmailSubject.ToString();
                    var emailBody = TemplateHelper.RenderTemplate(
                        MVC.Views.Administration.User.Membership.Account.SignUp.AccountActivateEmail, emailModel);

                    Common.EmailHelper.Send(emailSubject, emailBody, email);

                    uow.Commit();
                    UserRetrieveService.RemoveCachedUser(newUser.UserId, username);

                    return new ServiceResponse();
                }
            });
        }

        [HttpGet]
        public ActionResult Activate(string t)
        {
            using (var connection = SqlConnections.NewByKey("Default"))
            using (var uow = new UnitOfWork(connection))
            {
                int userId;
                try
                {
                    var bytes = MachineKey.Unprotect(Convert.FromBase64String(t), "Activate");
                    using (var ms = new MemoryStream(bytes))
                    using (var br = new BinaryReader(ms))
                    {
                        var dt = DateTime.FromBinary(br.ReadInt64());
                        if (dt < DateTime.UtcNow)
                            return Error(Texts.Validation.InvalidActivateToken);

                        userId = br.ReadInt32();
                    }
                }
                catch (Exception)
                {
                    return Error(Texts.Validation.InvalidActivateToken);
                }

                var user = uow.Connection.TryById<UserRow>(userId);
                if (user == null || user.IsActive != 0)
                    return Error(Texts.Validation.InvalidActivateToken);

                uow.Connection.UpdateById(new UserRow
                {
                    UserId = user.UserId.Value,
                    IsActive = 1
                });

                new UserRoleRepository().Update(uow, new UserRoleUpdateRequest
                {
                    UserID = user.UserId.Value,
                    Roles = new List<int> { (int) Constants.DefaultRoles.ACCOUNT }
                });
                //TODO add Account Role


                BatchGenerationUpdater.OnCommit(uow, UserRow.Fields.GenerationKey);
                uow.Commit();

                return new RedirectResult("~/Account/Login?activated=" + Uri.EscapeDataString(user.Email));
            }
        }
    }
}
