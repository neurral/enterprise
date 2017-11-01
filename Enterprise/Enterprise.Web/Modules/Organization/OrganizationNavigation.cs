using Serenity.Navigation;
using MyPages = Enterprise.Organization.Pages;
using Organization = Enterprise.Organization.Pages;

[assembly: NavigationMenu(8000, "Organization", icon: "fa-sitemap")]
[assembly: NavigationLink(8000, "Organization/Business Units", typeof(Organization.BusinessUnitController), icon: "fa-sitemap")]
[assembly: NavigationLink(8000, "Organization/Personnel", typeof(MyPages.PersonnelController), icon: null)]
[assembly: NavigationLink(8000, "Organization/Contacts", typeof(Organization.ContactController), icon: "fa-address-book")]
[assembly: NavigationLink(8000, "Organization/Meetings", typeof(Organization.MeetingController))]


[assembly: NavigationMenu(8000, "Organization/Libraries", icon: "fa-list")]
//[assembly: NavigationLink(8000, "Libraries/Personnel Status", typeof(MyPages.PersonnelStatusController), icon: null)]
[assembly: NavigationLink(8000, "Organization/Libraries/Meeting Agenda Types", typeof(Organization.MeetingAgendaTypeController))]
[assembly: NavigationLink(8000, "Organization/Libraries/Meeting Locations", typeof(Organization.MeetingLocationController))]
[assembly: NavigationLink(8000, "Organization/Libraries/Meeting Types", typeof(Organization.MeetingTypeController))]