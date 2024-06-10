using MVC_Project.Models;
using MVC_Project.ViewModels.Students;

namespace MVC_Project.Services.Interface
{
    public interface IStudentService
    {
        Task CreateAsync(Student student);
        Task DeleteAsync(Student student);
        Task EditAsync();
        Task<IEnumerable<StudentVM>> GetAllAsync(int? take);
        Task<Student> GetByIdAsync(int id);
        Task<bool> ExistAsync(string fullname);
    }
}
