
namespace Enterprise.Organization.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Organization/PersonnelStatus"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.PersonnelStatusRow))]
    public class PersonnelStatusController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Organization/PersonnelStatus/PersonnelStatusIndex.cshtml");
        }
    }
}