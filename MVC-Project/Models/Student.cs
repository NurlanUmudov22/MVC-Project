namespace MVC_Project.Models
{
    public class Student : BaseEntity
    {
        public string FullName { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }

        public string Profession { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
