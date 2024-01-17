using FirstLessonUI.Models.Data;
using FirstLessonUI.Models.Entity;
using FirstLessonUI.Models.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace FirstLessonUI.LanguageExtention
{
    public class FitnesLanguage
    {
        public FitnessActivityViewModel GetCenterLang(string lang, string con, int city, int region, int activity, int package,  PushDBContext db) {

            var model = db.Countries.FirstOrDefault(p => p.Language.ToLower() == con.ToLower());
            var vm = new FitnessActivityViewModel();
            if (model != null) {
                vm.Centers = db.Centers.Where(p => p.CountryId == model.Id).Include(i => i.Images).Include(p => p.CityFitCenters).Include(r => r.CentersRegions).Include(p => p.CenterActivities).Include(p => p.CenterPackages).ToList();
                if (city > 0)
                {
                    vm.Centers = vm.Centers.Where(p => p.CityFitCenters.Where(p => p.CityId == city).Count() > 0).ToList();
                }

                if (region > 0)
                {
                    vm.Centers = vm.Centers.Where(p => p.CentersRegions.Where(p => p.RegionId == region).Count() > 0).ToList();
                }

                if (activity > 0)
                {
                    vm.Centers = vm.Centers.Where(p => p.CenterActivities.Where(p => p.ActivityId == activity).Count() > 0).ToList();
                }

                if (package > 0)
                {
                    vm.Centers = vm.Centers.Where(p => p.CenterPackages.Where(p => p.PackageId == package).Count() > 0).ToList();
                }

                vm.CentersRegions = db.CentersRegions.Include(r => r.Regions).ToList();
                vm.CenterActivity = db.CenterActivities.Include(a => a.Activity).ToList();
                vm.CentersPackages = db.CentersPackages.Include(p => p.Packages).ToList();


                if (lang.ToLower() == "en")
                {



                    foreach (var item in vm.Centers)
                    {
                        item.Name = item.NameENG;
                        item.Description = item.DescriptionENG;
                        item.Note = item.NoteENG;
                    }

                    foreach (var item in vm.CentersRegions)
                    {
                        item.Regions.Name = item.Regions.NameENG;

                    }

                    foreach (var item in vm.CenterActivity)
                    {
                        item.Activity.Name = item.Activity.NameENG;
                        item.Activity.Description = item.Activity.DescriptionENG;

                    }
                    foreach (var item in vm.CentersPackages)
                    {
                        item.Packages.Name = item.Packages.NameENG;
                        item.Packages.Description = item.Packages.DescriptionENG;

                    }


                }
                if (lang.ToLower() == "ru")
                {



                    foreach (var item in vm.Centers)
                    {
                        item.Name = item.NameRUS;
                        item.Description = item.DescriptionRUS;
                        item.Note = item.NoteRUS;
                    }

                    foreach (var item in vm.CentersRegions)
                    {
                        item.Regions.Name = item.Regions.NameRUS;

                    }

                    foreach (var item in vm.CenterActivity)
                    {
                        item.Activity.Name = item.Activity.NameRUS;
                        item.Activity.Description = item.Activity.DescriptionRUS;

                    }
                    foreach (var item in vm.CentersPackages)
                    {
                        item.Packages.Name = item.Packages.NameRUS;
                        item.Packages.Description = item.Packages.DescriptionRUS;

                    }


                }
            }
            else
            {
                vm.Centers = db.Centers.Include(i => i.Images).Include(p => p.CityFitCenters).Include(r => r.CentersRegions).Include(p => p.CenterActivities).Include(p => p.CenterPackages).ToList();
                if (city > 0)
                {
                    vm.Centers = vm.Centers.Where(p => p.CityFitCenters.Where(p => p.CityId == city).Count() > 0).ToList();
                }

                if (region > 0)
                {
                    vm.Centers = vm.Centers.Where(p => p.CentersRegions.Where(p => p.RegionId == region).Count() > 0).ToList();
                }

                if (activity > 0)
                {
                    vm.Centers = vm.Centers.Where(p => p.CenterActivities.Where(p => p.ActivityId == activity).Count() > 0).ToList();
                }

                if (package > 0)
                {
                    vm.Centers = vm.Centers.Where(p => p.CenterPackages.Where(p => p.PackageId == package).Count() > 0).ToList();
                }

                vm.CentersRegions = db.CentersRegions.Include(r => r.Regions).ToList();
                vm.CenterActivity = db.CenterActivities.Include(a => a.Activity).ToList();
                vm.CentersPackages = db.CentersPackages.Include(p => p.Packages).ToList();


                if (lang.ToLower() == "en")
                {



                    foreach (var item in vm.Centers)
                    {
                        item.Name = item.NameENG;
                        item.Description = item.DescriptionENG;
                        item.Note = item.NoteENG;
                    }

                    foreach (var item in vm.CentersRegions)
                    {
                        item.Regions.Name = item.Regions.NameENG;

                    }

                    foreach (var item in vm.CenterActivity)
                    {
                        item.Activity.Name = item.Activity.NameENG;
                        item.Activity.Description = item.Activity.DescriptionENG;

                    }
                    foreach (var item in vm.CentersPackages)
                    {
                        item.Packages.Name = item.Packages.NameENG;
                        item.Packages.Description = item.Packages.DescriptionENG;

                    }


                }
                if (lang.ToLower() == "ru")
                {



                    foreach (var item in vm.Centers)
                    {
                        item.Name = item.NameRUS;
                        item.Description = item.DescriptionRUS;
                        item.Note = item.NoteRUS;
                    }

                    foreach (var item in vm.CentersRegions)
                    {
                        item.Regions.Name = item.Regions.NameRUS;

                    }

                    foreach (var item in vm.CenterActivity)
                    {
                        item.Activity.Name = item.Activity.NameRUS;
                        item.Activity.Description = item.Activity.DescriptionRUS;

                    }
                    foreach (var item in vm.CentersPackages)
                    {
                        item.Packages.Name = item.Packages.NameRUS;
                        item.Packages.Description = item.Packages.DescriptionRUS;

                    }


                }
            }
            

           

            return vm;
        }
    }
}
