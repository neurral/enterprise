using Serenity.Navigation;
using MyPages = Enterprise.Organization.Pages;
using Organization = Enterprise.Organization.Pages;

[assembly: NavigationMenu(8000, "Organization", icon: "fa-sitemap")]
[assembly: NavigationLink(8000, "Organization/Business Units", typeof(Organization.BusinessUnitController), icon: "fa-sitemap")]
[assembly: NavigationLink(8000, "Organization/Personnel", typeof(MyPages.PersonnelController), icon: "fa-users")]
//[assembly: NavigationLink(8000, "Organization/Contacts", typeof(Organization.ContactController), icon: "fa-address-book")]
//[assembly: NavigationLink(8000, "Organization/Meetings", typeof(Organization.MeetingController))]


[assembly: NavigationMenu(8200, "Libraries", icon: "fa-list")]
//[assembly: NavigationLink(8000, "Libraries/Personnel Status", typeof(MyPages.PersonnelStatusController), icon: null)]
//[assembly: NavigationLink(8000, "Organization/Libraries/Meeting Agenda Types", typeof(Organization.MeetingAgendaTypeController))]
//[assembly: NavigationLink(8000, "Organization/Libraries/Meeting Locations", typeof(Organization.MeetingLocationController))]
//[assembly: NavigationLink(8000, "Organization/Libraries/Meeting Types", typeof(Organization.MeetingTypeController))]
[assembly: NavigationLink(8200, "Libraries/Calendar Holiday", typeof(MyPages.CalendarHolidayController), icon: null)]
[assembly: NavigationLink(8200, "Libraries/Time Record Type", typeof(MyPages.TimeRecordTypeController), icon: null)]


[assembly: NavigationMenu(8300, "Timekeeping", icon: "fa-clock-o")]
[assembly: NavigationLink(8300, "Timekeeping/Time Record", typeof(MyPages.TimeRecordController), icon: null)]
[assembly: NavigationLink(8300, "Timekeeping/Time Record Approval", typeof(MyPages.TimeRecordApprovalController), icon: null)]
