using FirstLessonUI.Models;
using FirstLessonUI.Models.Data;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstLessonUI.Controllers
{
    public class HomeController : Controller
    {

        private readonly PushDBContext db;
        public HomeController(PushDBContext db)
        {
            this.db = db;
        }

        [Route("/")]
        [Route("/home/index/{lang}/{country}")]
        [Route("index/{lang}/{country}")]
        [Route("/{lang}/{country}")]
        public IActionResult Index(string lang, string con)
        {
            ViewData["db"] = db;
            if (lang == null && con == null)
            {
                lang = "az";
                con = "az";
            }

            ViewBag.Language = lang;
            ViewBag.Country = con;
            return View();
        }

        public IActionResult FitCenters()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}