
namespace Enterprise
{
    public class Constants
    {
        public const string GUID = "84da6417-8089-4e8e-9306-400b1c96415f";
        public const string ASSEMBLY_TITLE = "Enterprise.Web";
        public const string ASSEMBLY_DESCRIPTION = "Enterprise System for Corporations";
        public const string ASSEMBLY_CONFIGURATION = "";
        public const string ASSEMBLY_COMPANY = "Neurral Systems";
        public const string ASSEMBLY_PRODUCT = "Enterprise.Web";
        public const string ASSEMBLY_COPYRIGHT = "Copyright ©  2017";
        public const string ASSEMBLY_TRADEMARK = "Neurral";
        public const string ASSEMBLY_CULTURE = "en-us";

        public sealed class PersonnelStatus { 
            public const string INACTIVE = "Inactive"; //initial status
            public const string ACTIVATED = "Activated"; //usable account, included in transactions
            public const string SUSPENDED = "Suspended"; //unusable, included in transactions
            public const string TERMINATED = "Terminated"; //unusable, ignored except in history
        }

        public const string Enterprise_SCHEMA = "ent";
        public const string SCHEMA = Enterprise_SCHEMA + ".";
    }
}