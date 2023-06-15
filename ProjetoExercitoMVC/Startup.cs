using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using Microsoft.Extensions.DependencyInjection;
using ProjetoExercitoMVC.Data.Context;
using ProjetoExercitoMvcContext = ProjetoExercitoMVC.Data.Context.ProjetoExercitoMvcContext;
using ProjetoExercitoMVC.Services;

namespace ProjetoExercitoMVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<ProjetoExercitoMvcContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("ProjetoExercitoMvcContext"), builder => 
                    builder.MigrationsAssembly("ProjetoExercitoMVC")));

            services.AddScoped<MilitarService>();
            services.AddScoped<CompanhiaService>();
        }

        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        }
    }
}

