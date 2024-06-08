using MVC_Project.Models;
using MVC_Project.ViewModels.Informations;

namespace MVC_Project.Services.Interface
{
    public interface IInformationService
    {
        Task<IEnumerable<InformationVM>> GetAllAsync(int? take = null);
        Task<bool> ExistAsync(string title);
        Task CreateAsync(Information information);
        Task<Information> GetByIdAsync(int id);
        Task DeleteAsync(Information information);
        Task EditAsync();
        Task<bool> ExistByIdAsync(int id, string title);
    }
}
