using FirstLessonUI.Models.Data;
using FirstLessonUI.Models.Entity;
using Microsoft.AspNetCore.Mvc;

namespace FirstLessonUI.Areas.Admin.Controllers
{
    public class PackageController : Controller
    {
        private readonly PushDBContext db;

        public PackageController(PushDBContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var model = db.Packages.ToList();
            return View(model);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Add(Package pack)
        {

            db.Packages.Add(pack);
            db.SaveChanges();


            return RedirectToAction("index");
        }

        public IActionResult Update(int id)
        {
            var model = db.Packages.FirstOrDefault(p => p.Id == id);
            return View(model);
        }

        [HttpPost]
        [Obsolete]
        public IActionResult Update(Package package)
        {
            db.Packages.Update(package);
            db.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            var model = db.Packages.FirstOrDefault(x => x.Id == id);
            db.Packages.Remove(model);
            db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
