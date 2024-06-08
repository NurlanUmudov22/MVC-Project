using Microsoft.EntityFrameworkCore;
using MVC_Project.Data;
using MVC_Project.Models;
using MVC_Project.Services.Interface;

namespace MVC_Project.Services
{
    public class AboutService : IAboutService
    {

        private readonly AppDbContext _context;

        public AboutService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<About>> GetAllAsync()
        {
            return await _context.Abouts.Include(m => m.Informations).Where(m => !m.SoftDeleted).ToListAsync();
        }


    }
}
