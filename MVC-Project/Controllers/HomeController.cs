using Microsoft.AspNetCore.Mvc;
using MVC_Project.Services.Interface;
using MVC_Project.ViewModels;
using MVC_Project.ViewModels.Sliders;
using MVC_Project.ViewModels.Informations;
using MVC_Project.ViewModels.Abouts;
using MVC_Project.Helpers.Extensions;
using MVC_Project.Services;
using System.Data;
using MVC_Project.ViewModels.Students;



namespace MVC_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISliderService _sliderService;
        private readonly IInformationService _infoService; 
        private readonly IAboutService _aboutService;
        private readonly ICategoryService _categoryService;
        private readonly ICourseService _courseService;
        private readonly IInstructorService _instructorService;
        private readonly IStudentService _studentService;
        public HomeController(ISliderService sliderService,
                              IInformationService infoService,
                              IAboutService aboutService,
                              ICategoryService categoryService,
                              ICourseService courseService,
                              IInstructorService instructorService,
                              IStudentService studentService)
                              
        {
            _sliderService = sliderService;
            _infoService = infoService;
            _aboutService = aboutService;
            _categoryService = categoryService;
            _courseService = courseService;
            _instructorService = instructorService;
            _studentService = studentService;
            
        }

        public async Task<IActionResult> Index()
        {
            var slider = await _sliderService.GetAllAsync();
            var info = await _infoService.GetAllAsync();
            var about = await _aboutService.GetAllAsync();
            var datas = await _categoryService.GetAllWithProductCountAsync();

            HomeVM model = new()
            {
                Sliders = slider.Select(m => new SliderVM
                {
                    Id = m.Id,
                    Image = m.Image,
                    Title = m.Title,
                    Description = m.Description,
                    CreatedDate = m.CreatedDate

                }),

                Informations = info.Select(m => new InformationVM
                {
                    Id = m.Id,
                    Image = m.Image,
                    Title = m.Title,
                    Description = m.Description
                }),

                Abouts = await _aboutService.GetAllAsync(),


                CategoryFirst = datas.FirstOrDefault(),
                CategoryLast = datas.LastOrDefault(),
                Categories = datas.Skip(1).Take(2),

                Courses = await _courseService.GetAllAsync(),

                Instructors = await _instructorService.GetAllAsync(),

                //Students = await _studentService.GetAllAsync(),
          

            };
            return View(model);
        }



    }
}
