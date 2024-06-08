using Microsoft.EntityFrameworkCore;
using MVC_Project.Data;
using MVC_Project.Models;
using MVC_Project.Services.Interface;

namespace MVC_Project.Services
{
    public class SliderService : ISliderService
    {


        private readonly AppDbContext _context;

        public SliderService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Slider>> GetAllAsync()
        {
            return await _context.Sliders.Where(m => !m.SoftDeleted).ToListAsync();
        }


    }
}
