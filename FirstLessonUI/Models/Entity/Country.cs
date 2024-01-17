namespace FirstLessonUI.Models.Entity
{
    public class Country : BaseEntity, IForName
    {
        public string Name { get; set ; }
        public string CountryCode { get; set ; }
        public string Language { get; set ; }
        public string Currency { get; set ; }

        public virtual ICollection<City> Cities { get; set ; }
        public virtual ICollection<Region> Regions { get; set ; }
        public virtual ICollection<Centers> Centers { get; set ; }
        public virtual ICollection<Activity> Activities { get; set ; }
        public virtual ICollection<Package> Packages { get; set ; }
    }
}
