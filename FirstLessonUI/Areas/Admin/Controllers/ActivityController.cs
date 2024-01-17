using FirstLessonUI.Models.Data;
using FirstLessonUI.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using FirstLessonUI.Helper;

namespace FirstLessonUI.Areas.Admin.Controllers
{
    public class ActivityController : Controller
    {
        private readonly PushDBContext db;
        private Microsoft.AspNetCore.Hosting.IHostingEnvironment env;
        public ActivityController(PushDBContext db, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            this.db = db;
            this.env = env;
        }
        public IActionResult Index()
        {
            var model = db.Activities.ToList();
            return View(model);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Add(Activity activity, IFormFile imgPathh)
        {
            if (imgPathh == null)
            {
                ViewBag.imgPath = "Pleasу choose a picture (!)";

            }
            else
            {
                activity.ImgPath = Image.Add(imgPathh, env);
            }

            db.Activities.Add(activity);
            db.SaveChanges();


            return RedirectToAction("index");
        }

        public IActionResult Update(int id)
        {
            var model = db.Activities.FirstOrDefault(x => x.Id == id);
            return View(model);
        }

        [HttpPost]
        [Obsolete]
        public IActionResult Update(Activity activity, IFormFile imgPathh )
        {
            if (imgPathh != null)
            {
                Image.Delete(activity.ImgPath, env);

                activity.ImgPath = Image.Add(imgPathh, env);

            }


            db.Activities.Update(activity);
            db.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            var model = db.Activities.FirstOrDefault(x => x.Id == id);
            db.Activities.Remove(model);
            db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
