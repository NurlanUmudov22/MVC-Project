namespace MVC_Project.ViewModels.Informations
{
    public class InformationEditVM
    {
        public string Description { get; set; }

        public string Title { get; set; }

        public string Image { get; set; }
        public IFormFile NewImage { get; set; }
    }
}
