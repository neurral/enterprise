
namespace Enterprise.Organization.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Organization/Personnel"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.PersonnelRow))]
    public class PersonnelController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Organization/Personnel/PersonnelIndex.cshtml");
        }
    }
}