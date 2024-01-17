using FirstLessonUI.Models.Data;
using FirstLessonUI.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FirstLessonUI.Areas.Admin.Controllers
{
    public class RegionController : Controller
    {
        private readonly PushDBContext db;

        public RegionController(PushDBContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var model = db.Regions.Include(p=> p.City).ToList();
            return View(model);
        }

        public IActionResult Add()
        {
            ViewBag.City = new SelectList(db.Cities.ToList(), "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Add(Region info)
        {
            db.Regions.Add(info);
            db.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Update(int id)
        {
            var model = db.Regions.FirstOrDefault(r=>r.Id == id);
            return View(model);
        }

        [HttpPost]
        [Obsolete]
        public IActionResult Update(Region info)
        {

            db.Regions.Update(info);
            db.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            var model = db.Regions.FirstOrDefault(r => r.Id == id);
            db.Regions.Remove(model);
            db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
