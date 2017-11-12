
namespace Enterprise.Organization.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Organization/Organization"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.OrganizationRow))]
    public class OrganizationController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Organization/Organization/OrganizationIndex.cshtml");
        }
    }
}