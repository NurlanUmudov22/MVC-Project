using System.ComponentModel.DataAnnotations;

namespace MVC_Project.ViewModels.Category
{
    public class CategoryCreateVM
    {
        [Required(ErrorMessage = "This input can't be empty")]
        [StringLength(80)]
        public string Name { get; set; }
        public IFormFile Image { get; set; }
    }
}
