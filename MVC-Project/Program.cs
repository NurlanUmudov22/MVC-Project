using Microsoft.EntityFrameworkCore;
using MVC_Project.Data;
using MVC_Project.Services.Interface;
using MVC_Project.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));



builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();



builder.Services.AddScoped<ISliderService, SliderService>();

builder.Services.AddScoped<IInformationService, InformationService>();

builder.Services.AddScoped<IAboutService, AboutService>();

builder.Services.AddScoped<ICategoryService, CategoryService>();




var app = builder.Build();




app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
           name: "areas",
           pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
         );


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

