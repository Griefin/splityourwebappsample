using System.Web.Mvc;

namespace SplitYourWebAppSample.Movies.Controllers
{
    public class MoviesController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LatestNews()
        {
            return PartialView("~/Views/Movies/_LatestNews.cshtml");
        }
    }
}