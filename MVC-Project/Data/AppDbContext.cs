using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVC_Project.Models;
using System.Reflection.Metadata;

namespace MVC_Project.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        public DbSet<Slider> Sliders { get; set; }


        public DbSet<Information> Informations { get; set; }


        public DbSet<About> Abouts { get; set; }


        //public DbSet<Course> Courses { get; set; }
        //public DbSet<Category> Categories { get; set; }

        //public DbSet<Student> Students { get; set; }

        //public DbSet<CourseImage> CourseImages { get; set; }


    }
}