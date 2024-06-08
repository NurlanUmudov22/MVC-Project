using System.ComponentModel.DataAnnotations;

namespace MVC_Project.ViewModels.Informations
{
    public class InformationCreateVM
    {

        [Required(ErrorMessage = "This input can't be empty")]
        [StringLength(200)]
        public string Title { get; set; }


        public string Description { get; set; }

        public IFormFile Image { get; set; }
    }
}
