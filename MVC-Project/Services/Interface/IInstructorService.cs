using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Project.Models;

namespace MVC_Project.Services.Interface
{
    public interface IInstructorService
    {
        Task<IEnumerable<Instructor>> GetAllAsync();
        Task CreateAsync(Instructor instructor);
        Task DeleteAsync(Instructor instructor);
        Task EditAsync();
        Task<bool> ExistEmailAsync(string email);
        Task<SelectList> GetAllSelectedAsync();
        Task<Instructor> GetByIdAsync(int id);
        Task<Instructor> GetByIdWithSocialAsync(int id);
        Task<bool> ExistExceptByIdAsync(int id, string email);

    }
}
