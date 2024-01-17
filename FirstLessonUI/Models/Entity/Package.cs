namespace FirstLessonUI.Models.Entity
{
    public class Package : BaseEntity, IForName
    {
        public string Name { get; set; }
        public string? NameENG { get; set; }
        public string? NameRUS { get; set; }
        public string? NameAZE { get; set; }
        public string Description { get; set; }
        public string? DescriptionENG { get; set; }
        public string? DescriptionRUS { get; set; }
        public string? DescriptionAZE { get; set; }
        public decimal Price { get; set; }

        public int? CountryId { get; set; }
        public Country? Country { get; set; }
        public virtual ICollection<CentersPackage> CenterPackages { get; set; }
    }
}
