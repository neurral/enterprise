using Serenity.Navigation;
using Administration = Enterprise.Administration.Pages;

[assembly: NavigationMenu(9000, "Administration", icon: "icon-screen-desktop")]
[assembly: NavigationLink(9000, "Administration/Roles", typeof(Administration.RoleController), icon: "icon-lock")]
[assembly: NavigationLink(9000, "Administration/User Management", typeof(Administration.UserController), icon: "icon-people")]
//[assembly: NavigationLink(9000, "Administration/Languages", typeof(Administration.LanguageController), icon: "icon-bubbles")]
//[assembly: NavigationLink(9000, "Administration/Translations", typeof(Administration.TranslationController), icon: "icon-speech")]
[assembly: NavigationMenu(9000, "Administration/Security", icon: "fa-shield")]
[assembly: NavigationLink(9000, "Administration/Security/Exceptions Log", url: "~/errorlog.axd", permission: Enterprise.Administration.Keys.Security.Access, icon: "icon-ban", Target = "_blank")]
