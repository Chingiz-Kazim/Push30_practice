namespace FirstLessonUI.Models.Entity
{
    public class CenterImages : BaseEntity
    {
        public string Name { get; set; }
        public int CenterId { get; set; }
        public Centers Center { get; set; }
    }
}
