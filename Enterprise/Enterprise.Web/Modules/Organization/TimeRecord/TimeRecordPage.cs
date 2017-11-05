
namespace Enterprise.Organization.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Organization/TimeRecord"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.TimeRecordRow))]
    public class TimeRecordController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Organization/TimeRecord/TimeRecordIndex.cshtml");
        }
    }
}