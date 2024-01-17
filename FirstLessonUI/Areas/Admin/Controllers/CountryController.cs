using FirstLessonUI.Models.Data;
using FirstLessonUI.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FirstLessonUI.Areas.Admin.Controllers
{
    public class CountryController : Controller
    {
        private readonly PushDBContext db;
        public CountryController(PushDBContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var model = db.Countries.Include(p=> p.Cities).ToList();
            return View(model);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Country country)
        {
            db.Countries.Add(country);
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
