
using Enterprise.Common;
using Serenity.Extensibility;
using System.ComponentModel;

namespace Enterprise.Organization
{
    public class Ks
    {
        public const string Module = "Organization";

        public const string BusinessUnit = "BusinessUnit";
        public const string Personnel = "Personnel";
        public const string Contact = "Contact";
        public const string Meeting = "Meeting";

        public const string Libraries = "[Libraries]";
        public const string MeetingAgenda = "Agenda";
        public const string MeetingAgendaRelevant = "AgendaRelevant";
        public const string MeetingAgendaType = "AgendaType";
        public const string MeetingAttendee = "Attendee";
        public const string MeetingDecision = "Decision";
        public const string MeetingDecisionRelevant = "DecisionRelevant";
        public const string MeetingLocation = "MeetingLocation";
        public const string MeetingType = "MeetingType";
        public const string PersonnelStatus = "PersonnelStatus";
    }

    [NestedPermissionKeys]
    [DisplayName(Ks.Module)]
    public class Keys
    {
        [Description("[General]")]
        public const string General = Ks.Module + ":" +"General";


        [DisplayName("Business Unit")] //TODO rename this to Department
        public class BusinessUnit
        {
            public const string Access = Ks.Module + ":" +Ks.BusinessUnit + ":Access";
            [ImplicitPermission(General), ImplicitPermission(Access)]
            public const string Delete = Ks.Module + ":" +Ks.BusinessUnit + ":Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(Access)]
            public const string Modify = Ks.Module + ":" +Ks.BusinessUnit + ":Modify";
        }

        [DisplayName(Ks.Personnel)]
        public class Personnel
        {
            public const string Access = Ks.Module + ":" +Ks.Personnel + ":Access";
            [ImplicitPermission(General), ImplicitPermission(Access)]
            public const string Delete = Ks.Module + ":" +Ks.Personnel + ":Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(Access)]
            public const string Modify = Ks.Module + ":" +Ks.Personnel + ":Modify";
        }

        [DisplayName(Ks.Contact)]
        public class Contact
        {
            public const string Access = Ks.Module + ":" +Ks.Contact + ":Access";
            [ImplicitPermission(General), ImplicitPermission(Access)]
            public const string Delete = Ks.Module + ":" +Ks.Contact + ":Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(Access)]
            public const string Modify = Ks.Module + ":" +Ks.Contact + ":Modify";
        }


        [DisplayName(Ks.Meeting)]
        public class Meeting
        {
            public const string Access = Ks.Module + ":" +Ks.Meeting + ":Access";
            [ImplicitPermission(General), ImplicitPermission(Access)]
            public const string Delete = Ks.Module + ":" +Ks.Meeting + ":Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(Access)]
            public const string Modify = Ks.Module + ":" +Ks.Meeting + ":Modify";
        }

        [DisplayName(Ks.Libraries), Description("Reference Data")]
        public class Libraries
        {
            public const string Access = Ks.Module + ":" +Ks.Libraries + ":Access";
            [ImplicitPermission(General), ImplicitPermission(Access)]
            public const string Delete = Ks.Module + ":" +Ks.Libraries + ":Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(Access)]
            public const string Modify = Ks.Module + ":" +Ks.Libraries + ":Modify";
        }
    }
}
