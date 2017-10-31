
using Enterprise.Common;
using Serenity.Extensibility;
using System.ComponentModel;

namespace Enterprise.Organization
{
    [NestedPermissionKeys]
    public class PermissionKeys
    {
        private const string Module = "Organization";

        [Description("[General]")]
        public const string General = Module + ":[General]";

        [DisplayName("Business Units")]
        public class BusinessUnit
        {
            public const string Access = Module + "Business Units:Access";
            public const string Management = Module + ":Business Units:Management";
        }

        public class Contact
        {
            public const string Access = Module + "Contacts:Access";
            public const string Management = Module + ":Contacts:Management";
        }

        public class Personnel
        {
            public const string Access = Module + "Personnel:Access";
            public const string Management = Module + ":Personnel:Management";
        }

        [Description("[Maintenance]")]
        public class Maintenance {
            public const string Access = Module + "Maintenance:Access";
            public const string Management = Module + ":Maintenance:Management";

        }
    }
}
