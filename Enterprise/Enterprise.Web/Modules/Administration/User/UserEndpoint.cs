﻿

namespace Enterprise.Administration.Endpoints
{
    using Entities;
    using Membership;
    using Organization.Entities;
    using Organization.Repositories;
    using Repositories;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Services;
    using Serenity.Web;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using MyRepository = Repositories.UserRepository;
    using MyRow = Entities.UserRow;

    [RoutePrefix("Services/Administration/User"), Route("{action}")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class UserController : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MyRepository().Create(uow, request);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MyRepository().Update(uow, request);
        }
 
        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new MyRepository().Delete(uow, request);
        }

        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public UndeleteResponse Undelete(IUnitOfWork uow, UndeleteRequest request)
        {
            return new MyRepository().Undelete(uow, request);
        }

        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRepository().Retrieve(connection, request);
        }

        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyRepository().List(connection, request);
        }

        public RetrieveResponse<MyRow> ResendActivationLink(IDbConnection connection, RetrieveRequest request)
        {
            var response = new MyRepository().Retrieve(connection, request);
            var user = response.Entity;
            var personnelRecord = user.GetPersonnelRecord(connection);
           
            if (user != null) {
                var token = user.GetToken("Activate");
                var externalUrl = Config.Get<EnvironmentSettings>().SiteExternalUrl ??
                        Request.Url.GetLeftPart(UriPartial.Authority) + VirtualPathUtility.ToAbsolute("~/");

                var activateLink = UriHelper.Combine(externalUrl, "Account/Activate?t=");
                activateLink = activateLink + Uri.EscapeDataString(token);

                var emailModel = new ActivateEmailModel();
                emailModel.Username = user.Username;
                emailModel.DisplayName = (personnelRecord != null ? personnelRecord.FirstName : user.Username);
                emailModel.ActivateLink = activateLink;

                var emailSubject = Texts.Forms.Membership.SignUp.ActivateEmailSubject.ToString();
                var emailBody = TemplateHelper.RenderTemplate(
                    MVC.Views.Administration.User.Membership.Account.SignUp.AccountActivateEmail, emailModel);

                Common.EmailHelper.Send(emailSubject, emailBody, user.Email);
            }

            return response;
        }

        public RetrieveResponse<PersonnelRow> GetPersonnelRecord(IDbConnection connection, RetrieveRequest request)
        {
            var response = new MyRepository().Retrieve(connection, request);
            var user = response.Entity;
          
            return new RetrieveResponse<PersonnelRow>() { Entity=user.GetPersonnelRecord(connection)};
        }

        private static string[] permissionsUsedFromScript;

        /// <summary>
        /// This declares a dynamic script with key 'UserData' that will be available from client side.
        /// We don't cache it at dynamic script manager, because dynamic scripts are cached globally,
        /// similar to static variables, not per user.
        /// </summary>
        [NonAction, DataScript("UserData", CacheDuration = -1), ServiceAuthorize]
        public ScriptUserDefinition GetUserData()
        {
            var result = new ScriptUserDefinition();
            var user = Authorization.UserDefinition as UserDefinition;

            if (user == null)
            {
                result.Permissions = new Dictionary<string, bool>();
                return result;
            }

            result.UserId = user.UserId;
            result.Username = user.Username;
            result.DisplayName = user.DisplayName;
            result.IsAdmin = user.Username == "admin";

            result.Permissions = TwoLevelCache.GetLocalStoreOnly("ScriptUserPermissions:" + user.Id, TimeSpan.Zero,
                UserPermissionRow.Fields.GenerationKey, () =>
                {
                    var permissions = new Dictionary<string, bool>(StringComparer.OrdinalIgnoreCase);

                    if (permissionsUsedFromScript == null)
                    {
                        permissionsUsedFromScript = new UserPermissionRepository().ListPermissionKeys().Entities
                            .Where(permissionKey =>
                            {
                                // this sends permission information for all permission keys to client side.
                                // if you don't need all of them to be available from script, filter them here.
                                // this is recommended for security / performance reasons...
                                return true;
                            }).ToArray();
                    }

                    foreach (var permissionKey in permissionsUsedFromScript)
                    {
                        if (Authorization.HasPermission(permissionKey))
                            permissions[permissionKey] = true;
                    }

                    return permissions;
                });

            return result;
        }
    }
}
