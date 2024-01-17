namespace FirstLessonUI.Models.Entity
{
    public class Centers : BaseEntity, IForName
    {
        public string Name { get; set; }
        public string? NameENG { get; set; }
        public string? NameRUS { get; set; }
  
        public string Description { get; set; }
        public string? DescriptionENG { get; set; }
        public string? DescriptionRUS { get; set; }
        public string Note { get; set; }
        public string? NoteENG { get; set; }
        public string? NoteRUS { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<CenterImages>? Images { get; set; }
        public int? CountryId { get; set; }
        public Country? Country { get; set; }
        public virtual ICollection<CenterActivity> CenterActivities { get; set; }
        public virtual ICollection<CentersPackage> CenterPackages { get; set; }
        public virtual ICollection<CityFitCenters> CityFitCenters { get; set; }
        public virtual ICollection<CentersRegions> CentersRegions { get; set; }

    }
}
