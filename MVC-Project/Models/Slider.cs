using System.ComponentModel.DataAnnotations;

namespace MVC_Project.Models
{
    public class Slider :BaseEntity
    {
        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        [StringLength(800)]
        public string Description { get; set; }

        public string Image { get; set; }

    }
}
