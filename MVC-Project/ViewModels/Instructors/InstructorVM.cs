using MVC_Project.Models;
using MVC_Project.ViewModels.Instructors;

namespace MVC_Project.ViewModels.Instructors
{
    public class InstructorVM
    {
        
        public int Id { get; set; }
        
        public string FullName { get; set; }
        
        public string Image { get; set; }

        public string Email { get; set; }
        
        
        public string Designation { get; set; }


        public List<InstructorSocial> InstructorSocials { get; set; }
    }
}
