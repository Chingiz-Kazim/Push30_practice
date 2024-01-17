using FirstLessonUI.Helper;
using FirstLessonUI.Models.Data;
using FirstLessonUI.Models.Entity;
using Microsoft.AspNetCore.Mvc;

namespace FirstLessonUI.Areas.Admin.Controllers
{
    public class SiteInfoController : Controller
    {
        private readonly PushDBContext db;
        private Microsoft.AspNetCore.Hosting.IHostingEnvironment env;
        public SiteInfoController(PushDBContext db, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            this.db = db;
            this.env = env;
        }
        public IActionResult Index()
        {
            var model = db.SiteInfos.ToList();
            return View(model);
        }

        public IActionResult Add()
        {        
            return View();
        }

        [HttpPost]
        public IActionResult Add(SiteInfo info, IFormFile logosss, IFormFile iconnnnn)
        {
          if(logosss== null) { 
            ViewBag.logos = "Zehmet olmasa logonu secin";
            
            }
          else
            {
                info.Logo = Image.Add(logosss, env);
            }


            if (iconnnnn == null)
            {
                ViewBag.icon = "Zehmet olmasa iconu secin";

            }
            else
            {
                info.FavIcon = Image.Add(iconnnnn, env);
            }

            db.SiteInfos.Add(info);
            db.SaveChanges();


            return RedirectToAction("index");
        }

        public IActionResult Update(int id)
        {
            var model = db.SiteInfos.FirstOrDefault(x => x.Id == id);
            return View(model);
        }

        [HttpPost]
        [Obsolete]
        public  IActionResult Update(SiteInfo info, IFormFile logosss, IFormFile iconnnnn)
        {
            if (logosss != null)
            {
                Image.Delete(info.Logo, env);
          
                info.Logo = Image.Add(logosss, env);

            }

            if (iconnnnn != null)
            {
                Image.Delete(info.FavIcon, env);
                info.FavIcon = Image.Add(iconnnnn, env);

            }



            db.SiteInfos.Update(info);
            db.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            var model = db.SiteInfos.FirstOrDefault(x => x.Id == id);
            db.SiteInfos.Remove(model);
            db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
