namespace FirstLessonUI.Models.Entity
{
    public class City : BaseEntity, IForName
    {
        public string Name { get; set; }
        public string? NameENG { get; set; }
        public string? NameRUS { get; set; }
        public string? NameAZE { get; set; }

        public int? CountryId { get; set; }
        public Country? Country { get; set; }
        public virtual ICollection<Region> Regions { get; set; }
        public virtual ICollection<CityFitCenters> CityFitCenters { get; set; }
    }
}
