using Data.RepositoryConc;
using Ecommerce.Data.Data;
using Entities.Models;
using Entities.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using Utils;

namespace Ecommerce.Data
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("ApplicationDbContextConnection") ;

			// Add services to the container.
			builder.Services.AddControllersWithViews();

			builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

			builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
			builder.Services.AddScoped<IUserRepository, UserRepository>();
			builder.Services.AddSingleton<IEmailSender, EmailSender>();

			builder.Services.AddDbContext<ApplicationDbContext>(
				  options => options.UseSqlServer(builder.Configuration["ConnectionStrings:ApplicationDbContext"])
				);

         builder.Services.AddIdentity<IdentityUser,IdentityRole>().AddDefaultTokenProviders().AddDefaultUI()
				.AddEntityFrameworkStores<ApplicationDbContext>();

			

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

          

            app.UseHttpsRedirection();

			app.UseStaticFiles();

			app.UseRouting();
            
			app.UseAuthentication(); // Ensure this is added
            app.UseAuthorization();

			app.MapRazorPages();

            //app.MapGet("/", () => "Hello, World!");

            app.MapControllerRoute(
              name: "default",
              pattern: "{area=Home}/{controller=Home}/{action=Index}/{id?}"
                 );

            app.Run();
		}
	}
}
