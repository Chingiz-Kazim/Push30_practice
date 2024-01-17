using FirstLessonUI.Models.Entity;

namespace FirstLessonUI.Models.ViewModel
{
    public class FitnessActivityViewModel
    {
        public IEnumerable<Centers> Centers { get; set; }
        public IEnumerable<CenterActivity> CenterActivity { get; set; }
        public IEnumerable<CentersPackage> CentersPackages { get; set; }
        public  IEnumerable<CentersRegions> CentersRegions { get; set; }
    }
}
