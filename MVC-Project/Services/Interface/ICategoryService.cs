using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Project.Models;
using MVC_Project.ViewModels.Category;

namespace MVC_Project.Services.Interface
{
    public interface ICategoryService  
    {
        Task<IEnumerable<CategoryCourseVM>> GetAllWithProductCountAsync();
        Task<bool> ExistAsync(string name);
        Task CreateAsync(Category category);
        Task<Category> GetByIdAsync(int id);
        Task DeleteAsync(Category category);
        Task<IEnumerable<Category>> GetAllAsync();

        Task<SelectList> GetAllSelectedAsync();
        //Task<Category> GetByIdWithCoursesAsync(int id);
        Task<bool> ExistExceptByIdAsync(int id, string name);
        Task EditAsync();
    }
}
