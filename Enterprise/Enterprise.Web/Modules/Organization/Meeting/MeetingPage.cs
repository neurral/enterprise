
namespace Enterprise.Organization.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Organization/Meeting"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.MeetingRow))]
    public class MeetingController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Organization/Meeting/MeetingIndex.cshtml");
        }
    }
}