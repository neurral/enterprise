
namespace Enterprise.Organization.Pages
{
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Meeting/MeetingLocation"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.MeetingLocationRow))]
    public class MeetingLocationController : Controller
    {
        public ActionResult Index()
        {
            return View(MVC.Views.Organization.Meeting.MeetingLocation.MeetingLocationIndex);
        }
    }
}
