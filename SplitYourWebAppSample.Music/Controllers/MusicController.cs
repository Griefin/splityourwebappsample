using System.Web.Mvc;

namespace SplitYourWebAppSample.Music.Controllers
{
    [Authorize]
    public class MusicController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        [AllowAnonymous]        
        public ActionResult LatestNews()
        {
            return PartialView("~/Views/Music/_LatestNews.cshtml");
        }       

    }
}