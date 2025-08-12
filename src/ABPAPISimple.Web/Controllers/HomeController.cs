using Microsoft.AspNetCore.Mvc;

namespace ABPAPISimple.Web.Controllers
{
    public class HomeController : ABPAPISimpleControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}