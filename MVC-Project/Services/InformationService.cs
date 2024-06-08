using Microsoft.EntityFrameworkCore;
using MVC_Project.Data;
using MVC_Project.Models;
using MVC_Project.Services.Interface;

namespace MVC_Project.Services
{
    public class InformationService : IInformationService
    {
        private readonly AppDbContext _context;

        public InformationService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Information>> GetAllAsync()
        {
            return await _context.Informations.Where(m => !m.SoftDeleted).ToListAsync();
        }


    }
}
