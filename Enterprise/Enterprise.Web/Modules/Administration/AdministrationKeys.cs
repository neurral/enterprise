
using Serenity.Extensibility;
using System.ComponentModel;

namespace Enterprise.Administration
{ 
    public class Ks
    {
        public const string Module = "Administration";

        public const string User = "User";
        public const string Profile = "Profile";
        public const string Role = "Roles";
        public const string Security = "Security";

        public const string Libraries = "[Libraries]";
        public const string Language = "Language";

    }


    [NestedPermissionKeys]
    [DisplayName(Ks.Module)]
    public class Keys
    {

        [Description("[General]")]
        public const string General = Ks.Module + ":" + "General";


        [DisplayName("User Accounts")]
        public class User
        {
            public const string Access = Ks.Module + ":" + Ks.User + ":Access";
            [ImplicitPermission(General), ImplicitPermission(Access)]
            public const string Delete = Ks.Module + ":" + Ks.User + ":Delete";
            [Description("Create/Update"), ImplicitPermission(General)]
            public const string Modify = Ks.Module + ":" + Ks.User + ":Modify";

            [Description("Update Profile"), ImplicitPermission(Modify)]
            public const string Profile = Ks.Module + ":" + Ks.Profile + ":Profile";
        }

        [DisplayName("Roles and Permissions")]
        public class Role
        {
            public const string Access = Ks.Module + ":" + Ks.Role + ":Access";
            [ImplicitPermission(General), ImplicitPermission(Access)]
            public const string Delete = Ks.Module + ":" + Ks.Role + ":Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(Access)]
            public const string Modify = Ks.Module + ":" + Ks.Role + ":Modify";
        }

        [Description("Languages and Translations")]
        public const string Languages = Ks.Module + ":" + Ks.Language;
        
        [Description("Security and Logs")]
        public class Security
        {
            public const string Access = Ks.Module + ":" + Ks.Security + ":Access";

            [ImplicitPermission(General), ImplicitPermission(Access)]
            public const string Delete = Ks.Module + ":" + Ks.Security + ":Delete";

            [ImplicitPermission(General), ImplicitPermission(Access)]
            public const string Export = Ks.Module + ":" + Ks.Security + ":Export";

            public const string Samples = Ks.Module + ":" + Ks.Security + ":Samples";
        }
    }
}
