using System.Web;
using System.Web.Mvc;

namespace EventManager_Lazar_Boradzhiev
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
