using System.ComponentModel.DataAnnotations;

namespace MVC_Project.ViewModels.Sliders
{
    public class SliderCreateVM
    {
        [Required(ErrorMessage = "This input can't be empty")]
        [StringLength(200)]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public IFormFile Image { get; set; }
    }
}
