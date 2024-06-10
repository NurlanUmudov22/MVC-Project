using Microsoft.EntityFrameworkCore;
using MVC_Project.Data;
using MVC_Project.Models;
using MVC_Project.Services.Interface;
using MVC_Project.ViewModels.Abouts;

namespace MVC_Project.Services
{
    public class AboutService : IAboutService
    {

        private readonly AppDbContext _context;

        public AboutService(AppDbContext context)
        {
            _context = context;

        }
        public async Task CreateAsync(About about)
        {
            await _context.AddAsync(about);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(About about)
        {
            _context.Abouts.Remove(about);
            await _context.SaveChangesAsync();
        }

        public async Task EditAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<bool> ExistAsync(string title)
        {
            return await _context.Abouts.AnyAsync(m => m.Title.Trim() == title.Trim());
        }

        public async Task<bool> ExistByIdAsync(int id, string title)
        {
            return await _context.Abouts.AnyAsync(m => m.Title.Trim() == title.Trim() && m.Id != id);
        }

        public async Task<About> GetAllAsync()
        {
            return await _context.Abouts.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<AboutVM>> GetAllAsync(int? take = null)
        {
            IEnumerable<About> abouts;
            if (take is null)
            {
                abouts = await _context.Abouts.ToListAsync();
            }
            else
            {
                abouts = await _context.Abouts.Take((int)take).ToListAsync();
            }

            return abouts.Select(m => new AboutVM
            {
                Id = m.Id,
                Title = m.Title,
                Description = m.Description,
                Image = m.Image,
                CreatedDate = m.CreatedDate.ToString("MM.dd.yyyy")
            });
        }


        public async Task<About> GetByIdAsync(int id)
        {
            var datas = await _context.Abouts.Where(m => m.Id == id).FirstOrDefaultAsync();
            return datas;
        }

    }
}
