using FirstLessonUI.Models.Data;
using FirstLessonUI.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FirstLessonUI.Areas.Admin.Controllers
{
    public class CityController : Controller
    {
        private readonly PushDBContext db;
        public CityController(PushDBContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var model = db.Cities.Include(p=> p.Regions).ToList();
            return View(model);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(City city)
        {
            db.Cities.Add(city);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(City city)
        {
            db.Cities.Update(city);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult Delete(int id)
        {
            var model = db.Cities.FirstOrDefault(r => r.Id == id);
            db.Cities.Remove(model);
            db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
