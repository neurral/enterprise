
using Serenity.Extensibility;
using System.ComponentModel;

namespace Enterprise.Administration
{
    [NestedPermissionKeys]
    [DisplayName("Administration")]
    public class PermissionKeys
    {
        [Description("Profile Management")]
        public const string Profile = "Administration:Profile Management";

        [Description("Users and Role Management and Permissions")]
        public const string Security = "Administration:Security";

        [Description("Languages and Translations")]
        public const string Translation = "Administration:Translation";
    }
}
