
namespace Enterprise.Organization.Pages
{
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Meeting/MeetingAgendaType"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.MeetingAgendaRow))]
    public class MeetingAgendaTypeController : Controller
    {
        public ActionResult Index()
        {
            return View(MVC.Views.Organization.Meeting.MeetingAgendaType.MeetingAgendaTypeIndex);
        }
    }
}
