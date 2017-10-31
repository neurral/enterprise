
namespace Enterprise.Organization.Pages
{
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Organization/Meeting"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.MeetingRow))]
    public class MeetingController : Controller
    {
        public ActionResult Index()
        {
            return View(MVC.Views.Organization.Meeting.MeetingIndex);
        }
    }
}
