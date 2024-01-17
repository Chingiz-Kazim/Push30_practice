namespace FirstLessonUI.Models.Entity
{
    public class SiteInfo: BaseEntity, IForName
    {
        public string Logo { get; set; }
        public string FavIcon { get; set; }
        public string Number { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public string? NameENG { get; set; }
        public string? NameRUS { get; set; }
        public string? NameAZE { get; set; }
    }
}
