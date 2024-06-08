using MVC_Project.Models;

namespace MVC_Project.Services.Interface
{
    public interface IInformationService
    {
        Task<IEnumerable<Information>> GetAllAsync();

    }
}
