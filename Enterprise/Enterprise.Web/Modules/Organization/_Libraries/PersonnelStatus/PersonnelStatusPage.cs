
namespace Enterprise.Organization.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("_Libraries/PersonnelStatus"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.PersonnelStatusRow))]
    public class PersonnelStatusController : Controller
    {
        public ActionResult Index()
        {
            return View(MVC.Views.Organization._Libraries.PersonnelStatus.PersonnelStatusIndex);
        }
    }
}