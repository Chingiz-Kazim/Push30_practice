using FirstLessonUI.Models.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstLessonUI.Controllers
{
    public class FitnessController : Controller
    {
        private readonly PushDBContext db;
        public FitnessController(PushDBContext db)
        {
            this.db = db;
        }
        // GET: FitnessController
        public ActionResult Index(int city, int region, int activity, int package)
        {
            ViewData["db"] = db;

            ViewBag.City = city;
            ViewBag.Region = region;
            ViewBag.Activity = activity;
            ViewBag.Package = package;
            return View();
        }

        // GET: FitnessController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FitnessController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FitnessController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FitnessController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FitnessController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FitnessController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FitnessController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
