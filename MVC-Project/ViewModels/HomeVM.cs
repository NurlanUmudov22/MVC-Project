using MVC_Project.Models;
using MVC_Project.ViewModels.Abouts;
using MVC_Project.ViewModels.Category;
using MVC_Project.ViewModels.Informations;
using MVC_Project.ViewModels.Sliders;

namespace MVC_Project.ViewModels
{
    public class HomeVM
    {

        public IEnumerable<SliderVM> Sliders { get; set; }

        public IEnumerable<InformationVM> Informations { get; set; }

        public About Abouts { get; set; }
        public IEnumerable<AboutVM> About { get; set; }

        public CategoryCourseVM CategoryFirst { get; set; }
        public CategoryCourseVM CategoryLast { get; set; }
        public IEnumerable<CategoryCourseVM> Categories { get; set; }


        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Instructor> Instructors { get; set; }

        public IEnumerable<Student> Students { get; set; }


    }
}
