using MVC_Project.Models;

namespace MVC_Project.Services.Interface
{
    public interface ISliderService
    {

        Task<IEnumerable<Slider>> GetAllAsync();

    }
}
