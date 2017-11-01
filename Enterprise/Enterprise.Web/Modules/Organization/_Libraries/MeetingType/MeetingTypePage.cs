
namespace Enterprise.Organization.Pages
{
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("_Libraries/MeetingType"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.MeetingTypeRow))]
    public class MeetingTypeController : Controller
    {
        public ActionResult Index()
        {
            return View(MVC.Views.Organization._Libraries.MeetingType.MeetingTypeIndex);
        }
    }
}
