
namespace Enterprise.Membership
{
    using Serenity.ComponentModel;
    using Serenity.Services;
    using System.ComponentModel;

    [FormScript("Membership.ChangePassword")]
    public class ChangePasswordRequest : ServiceRequest
    {
        [PasswordEditor, Required(true), DisplayName("Current Password"), Placeholder("Current Password")]
        public string OldPassword { get; set; }
        [PasswordEditor, Required(true), DisplayName("New Password"), Placeholder("New Password")]
        public string NewPassword { get; set; }
        [PasswordEditor, Required(true), DisplayName("Confirm Password"), Placeholder("Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}