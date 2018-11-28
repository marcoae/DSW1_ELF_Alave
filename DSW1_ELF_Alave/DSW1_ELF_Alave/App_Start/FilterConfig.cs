using System.Web;
using System.Web.Mvc;

namespace DSW1_ELF_Alave
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
