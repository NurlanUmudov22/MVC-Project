using MVC_Project.Models;
using MVC_Project.ViewModels.Sliders;

namespace MVC_Project.Services.Interface
{
    public interface ISliderService
    {

        //Task<IEnumerable<Slider>> GetAllAsync();




        Task<IEnumerable<SliderVM>> GetAllAsync(int? take = null);
        Task<bool> ExistAsync(string title);
        Task CreateAsync(Slider slider);
        Task<Slider> GetByIdAsync(int id);
        Task DeleteAsync(Slider slider);
        Task EditAsync();
        Task<bool> ExistByIdAsync(int id, string title);
    }
}
