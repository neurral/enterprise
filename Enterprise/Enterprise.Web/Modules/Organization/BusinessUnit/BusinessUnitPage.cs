
namespace Enterprise.Organization.Pages
{
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Organization/BusinessUnit"), Route("{action=index}")]
    [PageAuthorize(PermissionKeys.BusinessUnit.Access)]
    public class BusinessUnitController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Organization/BusinessUnit/BusinessUnitIndex.cshtml");
        }
    }
}
