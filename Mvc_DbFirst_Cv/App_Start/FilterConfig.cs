using System.Web;
using System.Web.Mvc;

namespace Mvc_DbFirst_Cv
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
