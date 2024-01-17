namespace FirstLessonUI.Models.Entity
{
    public class Category : BaseEntity, IForName
    {
        public string Name { get; set; }
        public string? NameENG { get; set; }
        public string? NameRUS { get; set; }
        public string? NameAZE { get; set; }
    }
}
