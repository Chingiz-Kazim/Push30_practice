namespace FirstLessonUI.Models.Entity
{
    public class Blog : BaseEntity, IForName
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgPath { get; set; }

    }
}
