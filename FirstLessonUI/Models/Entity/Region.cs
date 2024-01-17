namespace FirstLessonUI.Models.Entity;

public class Region : BaseEntity, IForName
{
    public string Name { get; set; }
    public string? NameENG { get; set; }
    public string? NameRUS { get; set; }
    public string? NameAZE { get; set; }
    public int? CityId { get; set; }
    public City? City { get; set; }
    public int? CountryId { get; set; }
    public Country? Country { get; set; }
    public virtual ICollection<CentersRegions> CentersRegions { get; set; }
}
