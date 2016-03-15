using System.Web.Mvc;

namespace SplitYourWebAppSample.Music.Controllers
{
    public class HomeController : Controller
    {        
        public ActionResult Index()
        {
            return View();
        }
    }
}