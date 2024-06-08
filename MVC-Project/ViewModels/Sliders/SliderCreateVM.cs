using System.ComponentModel.DataAnnotations;

namespace MVC_Project.ViewModels.Sliders
{
    public class SliderCreateVM
    {

        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public List<IFormFile> Images { get; set; }
    }
}
