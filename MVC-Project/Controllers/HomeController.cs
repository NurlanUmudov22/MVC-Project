using Microsoft.AspNetCore.Mvc;
using MVC_Project.Services.Interface;
using MVC_Project.ViewModels;
using MVC_Project.ViewModels.Sliders;
using MVC_Project.ViewModels.Informations;
using MVC_Project.ViewModels.Abouts;


namespace MVC_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISliderService _sliderService;
        private readonly IInformationService _infoService; 
        private readonly IAboutService _aboutService;
        public HomeController(ISliderService sliderService,
                              IInformationService infoService,
                              IAboutService aboutService)
                              
        {
            _sliderService = sliderService;
            _infoService = infoService;
            _aboutService = aboutService;
           
        }

        public async Task<IActionResult> Index()
        {
            var slider = await _sliderService.GetAllAsync();
            var info = await _infoService.GetAllAsync();
            var about = await _aboutService.GetAllAsync();
            HomeVM model = new()
            {
                Sliders = slider.Select(m => new SliderVM
                {
                    Id = m.Id,
                    Image = m.Image,
                    Title = m.Title,
                    Description = m.Description
                }),

                Informations = info.Select(m => new InformationVM
                {
                    Id = m.Id,
                    Image = m.Image,
                    Title = m.Title,
                    Description = m.Description
                }),


                  Abouts = info.Select(m => new AboutVM
                  {
                      Id = m.Id,
                      Image = m.Image,
                      Title = m.Title,
                      Description = m.Description,
                      //InfoTitle = m.About.Informations

                  })

            };
            return View(model);
        }



    }
}
