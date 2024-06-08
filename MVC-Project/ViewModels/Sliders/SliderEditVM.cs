namespace MVC_Project.ViewModels.Sliders
{
    public class SliderEditVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public IFormFile NewImage { get; set; }
    }
}
