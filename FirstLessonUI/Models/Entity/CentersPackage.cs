namespace FirstLessonUI.Models.Entity
{
    public class CentersPackage
    {
        public int CenterId { get; set; }
        public Centers Center { get; set; }
        public int PackageId { get; set; }
        public Package Packages { get; set; }
    }
}
