namespace FirstLessonUI.Models.Entity
{
    public class Activity : BaseEntity, IForName
    {
        public string Name { get; set; }
        public string? NameENG { get; set; }
        public string? NameRUS { get; set; }
        public string? NameAZE { get; set; }
        public string ImgPath { get; set; }
        public string Description { get; set; }
        public string? DescriptionENG { get; set; }
        public string? DescriptionRUS { get; set; }
        public string? DescriptionAZE { get; set; }

        public int? CountryId { get; set; }
        public Country? Country { get; set; }
        public virtual ICollection<CenterActivity> CenterActivities { get; set; }

    } 
}
