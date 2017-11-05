
namespace Enterprise.Organization.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Organization/TimeRecordType"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.TimeRecordTypeRow))]
    public class TimeRecordTypeController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Organization/TimeRecord/TimeRecordType/TimeRecordTypeIndex.cshtml");
        }
    }
}