using MVC_Project.Models;

namespace MVC_Project.Services.Interface
{
    public interface IAboutService
    {
        Task<IEnumerable<About>> GetAllAsync();

    }
}
