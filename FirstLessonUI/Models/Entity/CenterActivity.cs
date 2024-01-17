namespace FirstLessonUI.Models.Entity
{
    public class CenterActivity
    {
        public int CenterId { get; set; }
        public Centers Center { get; set; }

        public int ActivityId { get; set; }
        public Activity Activity { get; set; }

    }
}
