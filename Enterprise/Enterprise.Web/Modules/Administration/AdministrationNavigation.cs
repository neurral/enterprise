﻿using Serenity.Navigation;
using Administration = Enterprise.Administration.Pages;

[assembly: NavigationMenu(1000, "Administration", icon: "fa-gear")]
[assembly: NavigationLink(1000, "Administration/Roles", typeof(Administration.RoleController), icon: "icon-lock")]
[assembly: NavigationLink(1000, "Administration/Users", typeof(Administration.UserController), icon: "icon-people")]
[assembly: NavigationLink(int.MaxValue, "Administration/Organizations", typeof(Enterprise.Organization.Pages.OrganizationController), icon: "fa-sitemap")]
//[assembly: NavigationLink(1000, "Administration/Languages", typeof(Administration.LanguageController), icon: "icon-bubbles")]
//[assembly: NavigationLink(1000, "Administration/Translations", typeof(Administration.TranslationController), icon: "icon-speech")]
[assembly: NavigationMenu(1000, "Administration/Security", icon: "fa-id-card")]
[assembly: NavigationLink(1000, "Administration/Security/Exceptions Log", url: "~/errorlog.axd", permission: Enterprise.Administration.Keys.Security.Access, icon: "icon-ban", Target = "_blank")]
