
namespace Enterprise.Organization.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Organization/TimeRecordApproval"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.TimeRecordApprovalRow))]
    public class TimeRecordApprovalController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Organization/TimeRecord/TimeRecordApproval/TimeRecordApprovalIndex.cshtml");
        }
    }
}