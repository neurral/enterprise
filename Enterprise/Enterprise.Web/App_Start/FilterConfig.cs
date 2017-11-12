using System.Web;
using System.Web.Mvc;

namespace Enterprise
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new Serenity.Services.AntiforgeryCookieResultFilter());
            filters.Add(new Serenity.Services.AutoValidateAntiforgeryTokenAttribute());
            if (!HttpContext.Current.IsDebuggingEnabled)
            {
                filters.Add(new RequireHttpsAttribute());
            }
        }
    }
}