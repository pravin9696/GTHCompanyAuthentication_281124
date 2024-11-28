using System.Web;
using System.Web.Mvc;

namespace GTHCompanyAuthentication_281124
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
