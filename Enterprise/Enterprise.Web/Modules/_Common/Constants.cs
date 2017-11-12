
using Serenity.ComponentModel;
using System.ComponentModel;

namespace Enterprise
{
    public partial class Constants
    {
        public const string GUID = "84da6417-8089-4e8e-9306-400b1c96415f";
        public const string ASSEMBLY_TITLE = "Enterprise.Web";
        public const string ASSEMBLY_DESCRIPTION = "Enterprise System for Corporations";
        public const string ASSEMBLY_CONFIGURATION = "";
        public const string ASSEMBLY_COMPANY = "Neurral Systems";
        public const string ASSEMBLY_PRODUCT = "Enterprise.Web";
        public const string ASSEMBLY_COPYRIGHT = "Copyright ©  2017";
        public const string ASSEMBLY_TRADEMARK = "Neurral";
        public const string ASSEMBLY_CULTURE = "";

        public const string Enterprise_SCHEMA = "ent";
        public const string SCHEMA = Enterprise_SCHEMA + ".";
        public const string DEFAULT_DOMAIN = "@neurral.info";

        public enum Gender
        {
            Undefined = 0,
            Male = 1,
            Female = 2
        }

        
        public sealed class PersonnelStatus
        {
            public const string UNVERIFIED = "unverified"; //initial status
            public const string INACTIVE = "inactive"; //unusable account, included
            public const string ACTIVATED = "activated"; //usable account, included in transactions
            public const string SUSPENDED = "suspended"; //unusable, included in transactions
            public const string TERMINATED = "terminated"; //unusable, ignored except in history
        }

        [ScriptInclude]
        public enum PersonnelStatusIds
        {
            UNVERIFIED = 1,
            INACTIVE = 2,
            ACTIVATED = 3,
            SUSPENDED = 4,
            TERMINATED = 5
        }


        //also seeded in DB
        [ScriptInclude]
        public enum DefaultRoles
        {
            UNVERIFIED = 0,
            ADMINISTRATOR = 1,
            BOT = 2,
            ACCOUNT = 3,
            SUBACCOUNT = 4
        }

        [ScriptInclude]
        public enum ApprovalStatuses
        {   
            [Description("Locked for editing")]
            LOCKED = 0,
            [Description("Submitted")]
            SUBMITTED = 1,
            [Description("Cancelled")]
            CANCELLED = 2,
            [Description("Approved")]
            APPROVED = 3,
            [Description("Rejected")]
            REJECTED = 4
        }
        
        public sealed class TimeRecordType
        {
            public const string DTR = "DTR"; 
            public const string OT = "OT"; 
            public const string UT = "UT"; 
            public const string LATE = "LATE"; 
            public const string SPECIAL = "SPECIAL"; //special billed time like travel or events
        }

    }
}