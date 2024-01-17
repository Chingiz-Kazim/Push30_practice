using FirstLessonUI.LanguageExtention;
using FirstLessonUI.Models.Data;
using FirstLessonUI.Models.Entity;
using FirstLessonUI.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FirstLessonUI.ViewComponents
{
    public class CentersViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(PushDBContext db, int city, int region, int activity, int package, string lang,  string con)
        {
            //var vm = new FitnessActivityViewModel();

            //vm.Centers = db.Centers.Include(i=> i.Images).Include(p=> p.CityFitCenters).Include(r=>r.CentersRegions).Include(p=> p.CenterActivities).Include(p=>p.CenterPackages).ToList();

            //if(city > 0)
            //{
            //    vm.Centers = vm.Centers.Where(p=> p.CityFitCenters.Where(p=> p.CityId ==  city).Count() > 0).ToList();
            //}

            //if (region > 0)
            //{
            //    vm.Centers = vm.Centers.Where(p => p.CentersRegions.Where(p => p.RegionId == region).Count() > 0).ToList();
            //}

            //if (activity > 0)
            //{
            //    vm.Centers = vm.Centers.Where(p => p.CenterActivities.Where(p => p.ActivityId == activity).Count() > 0).ToList();
            //}

            //if (package > 0)
            //{
            //    vm.Centers = vm.Centers.Where(p => p.CenterPackages.Where(p => p.PackageId == package).Count() > 0).ToList();
            //}

            //vm.CentersRegions = db.CentersRegions.Include(r=>r.Regions).ToList();
            //vm.CenterActivity = db.CenterActivities.Include(a=> a.Activity).ToList();
            //vm.CentersPackages = db.CentersPackages.Include(p=>p.Packages).ToList();

            var model1 = new FitnesLanguage();

            var model2 = model1.GetCenterLang(lang, con, city, region, activity, package, db);
            return View(model2);
        }

    }
}
