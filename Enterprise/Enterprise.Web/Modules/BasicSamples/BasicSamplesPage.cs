
namespace Enterprise.BasicSamples.Pages
{
    using Serenity.Web;
    using System.Web.Mvc;

    [Authorize, RoutePrefix("BasicSamples"), Route("{action=index}"), 
        PageAuthorize(Enterprise.Administration.Keys.Security.Samples)]
    public partial class BasicSamplesController : Controller
    {
    }
}
