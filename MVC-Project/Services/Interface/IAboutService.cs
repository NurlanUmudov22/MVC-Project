using MVC_Project.Models;
using MVC_Project.ViewModels.Abouts;

namespace MVC_Project.Services.Interface
{
    public interface IAboutService
    {
        Task<IEnumerable<AboutVM>> GetAllAsync(int? take = null);
        Task<bool> ExistAsync(string title);
        Task CreateAsync(About about);
        Task<About> GetByIdAsync(int id);
        Task DeleteAsync(About about);
        Task EditAsync();
        Task<bool> ExistByIdAsync(int id, string title);
        Task<About> GetAllAsync();
    }
}
