
namespace Enterprise.Organization.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Organization/CalendarHoliday"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.CalendarHolidayRow))]
    public class CalendarHolidayController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Organization/CalendarHoliday/CalendarHolidayIndex.cshtml");
        }
    }
}