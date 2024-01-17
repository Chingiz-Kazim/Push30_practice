namespace FirstLessonUI.Models.Entity
{
    public class CityFitCenters
    {
        public int CityId { get; set; }
        public City City { get; set; }
        public int CenterId { get; set; }
        public Centers Center { get; set; }
        
    }
}
