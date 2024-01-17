using FirstLessonUI.Helper;
using FirstLessonUI.Models.Data;
using FirstLessonUI.Models.Entity;
using FirstLessonUI.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FirstLessonUI.Areas.Admin.Controllers
{
    public class CentersController : Controller
    {
        private readonly PushDBContext db;
        private Microsoft.AspNetCore.Hosting.IHostingEnvironment env;

        public CentersController(PushDBContext pushDBContext, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            this.db = pushDBContext;
            this.env = env;
        }

        public IActionResult Index()
        {
            var vm = new FitnessActivityViewModel();

            vm.Centers = db.Centers.Include(i => i.Images).ToList();
            vm.CenterActivity = db.CenterActivities.Include(a => a.Activity).ToList();
            vm.CentersPackages = db.CentersPackages.Include(p => p.Packages).ToList();
            vm.CentersRegions = db.CentersRegions.Include(r=> r.Regions).ToList();

            return View(vm);
        }

        public IActionResult Add()
        {
            ViewBag.Activity = new SelectList(db.Activities.ToList(), "Id", "Name");
            ViewBag.Package = new SelectList(db.Packages.ToList(), "Id", "Name");
            ViewBag.City = new SelectList(db.Cities.ToList(), "Id", "Name");
            ViewBag.Region = new SelectList(db.Regions.ToList(), "Id", "Name");
            ViewBag.Country = new SelectList(db.Countries.ToList(), "Id", "Name");
            return View();
        }

        [HttpPost]

        public IActionResult Add(Centers center, List<IFormFile> imagess, List<int> actvt, List<int> PackAges, int city, int region)
        {

            center.Images = new List<CenterImages>();
            center.CenterActivities = new List<CenterActivity>();
            center.CenterPackages = new List<CentersPackage>();
            center.CityFitCenters = new List<CityFitCenters>();
            center.CentersRegions = new List<CentersRegions>();

            var exampleC = new CityFitCenters();
            exampleC.CityId = city;
           
            center.CityFitCenters.Add(exampleC);

            var exampleR = new CentersRegions();
            exampleR.RegionId = region;

            center.CentersRegions.Add(exampleR);

            foreach (var item in actvt)
            {
                var a = new CenterActivity();
                a.ActivityId = item;
                center.CenterActivities.Add(a);
            }

            foreach (var item in PackAges)
            {
                var p = new CentersPackage();
                p.PackageId = item;
                center.CenterPackages.Add(p);
            }

            foreach (var item in imagess)
            {
                var image = new CenterImages();

                image.Name = Image.Add(item, env);

                center.Images.Add(image);
            }

            db.Centers.Add(center);
            db.SaveChanges();
            return RedirectToAction("index");
        }



        public IActionResult Update(int id)
        {
            ViewBag.Package = new SelectList(db.Packages.ToList(), "Id", "Name");
            ViewBag.City = new SelectList(db.Cities.ToList(), "Id", "Name");
            ViewBag.Region = new SelectList(db.Regions.ToList(), "Id", "Name");
            ViewBag.Activity = new SelectList(db.Activities.ToList(), "Id", "Name");
            ViewBag.Country = new SelectList(db.Countries.ToList(), "Id", "Name");
            if (id > 0)
            {
                var model = db.Centers.Include(i => i.Images)
                    .Include(a => a.CenterActivities)
                    .Include(p => p.CenterPackages)
                    .Include(c => c.CityFitCenters)
                    .Include(r=>r.CentersRegions)
                    .FirstOrDefault(m => m.Id == id);
                return View(model);
            }
            else
            {
                return RedirectToAction("index");
            }

        }

        [HttpPost]

        public IActionResult Update(Centers center, List<IFormFile> imagess, List<int> actvt, List<int> PackAges, int city, int region)
        {
            center.Images = new List<CenterImages>();
            center.CenterActivities = new List<CenterActivity>();
            center.CenterPackages = new List<CentersPackage>();
            center.CityFitCenters = new List<CityFitCenters>();
            center.CentersRegions = new List<CentersRegions>();
            center.UpdateDate = DateTime.Now;

            if (actvt.Count > 0)
            {
                var ac = db.CenterActivities.Where(p => p.CenterId == center.Id).ToList();

                db.CenterActivities.RemoveRange(ac);
                db.SaveChanges();
            }

            if (PackAges.Count > 0)
            {
                var pa = db.CentersPackages.Where(p => p.CenterId == center.Id).ToList();

                db.CentersPackages.RemoveRange(pa);
                db.SaveChanges();
            }

            if (city > 0)
            {
                var ci = db.CityFitCenters.FirstOrDefault(c => c.CityId == city);
                db.CityFitCenters.Update(ci);
                db.SaveChanges();
            }

            if (region > 0)
            {
                var reg = db.CentersRegions.FirstOrDefault(c => c.RegionId == region);
                db.CentersRegions.Update(reg);
                db.SaveChanges();
            }

            foreach (var item in actvt)
            {
                var a = new CenterActivity();
                a.ActivityId = item;
                a.CenterId = center.Id;
                center.CenterActivities.Add(a);
            }

            foreach (var item in PackAges)
            {
                var p = new CentersPackage();
                p.PackageId = item;
                p.CenterId = center.Id;
                center.CenterPackages.Add(p);
            }

            if (imagess.Count > 0)
            {
                foreach (var item in center.Images)
                {
                    Image.Delete(item.Name, env);
                }

                foreach (var item in imagess)
                {
                    var image = new CenterImages();

                    image.Name = Image.Add(item, env);
                    image.CenterId = center.Id;
                    center.Images.Add(image);
                }
            }

            db.CenterImages.AddRange(center.Images);
            db.CenterActivities.AddRange(center.CenterActivities);
            db.CentersPackages.AddRange(center.CenterPackages);
            db.Centers.Update(center);
            db.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult Delete(int id)
        {
            var model = db.Centers.FirstOrDefault(x => x.Id == id);
            db.Centers.Remove(model);
            db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
