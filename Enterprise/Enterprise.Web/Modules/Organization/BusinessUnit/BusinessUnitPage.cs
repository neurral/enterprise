﻿
namespace Enterprise.Organization.Pages
{
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Organization/BusinessUnit"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.BusinessUnitRow))]
    public class BusinessUnitController : Controller
    {
        public ActionResult Index()
        {
            return View(MVC.Views.Organization.BusinessUnit.BusinessUnitIndex);
        }
    }
}
