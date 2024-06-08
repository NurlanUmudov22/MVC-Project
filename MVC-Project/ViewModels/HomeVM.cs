using MVC_Project.Models;
using MVC_Project.ViewModels.Abouts;
using MVC_Project.ViewModels.Informations;
using MVC_Project.ViewModels.Sliders;

namespace MVC_Project.ViewModels
{
    public class HomeVM
    {

        public IEnumerable<SliderVM> Sliders { get; set; }

        public IEnumerable<InformationVM> Informations { get; set; }

        public About Abouts { get; set; }
        //public IEnumerable<AboutVM> About { get; set; }

    }
}
