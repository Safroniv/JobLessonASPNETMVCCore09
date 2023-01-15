using JobLessonASPNETMVCCore09v01.Services.Impl;
using JobLessonASPNETMVCCore09v01.Services;

namespace JobLessonASPNETMVCCore09v01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddSingleton<IEmployeesRepository, EmployeesRepository>();

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            //app.MapGet("/", () => "Hello World!");
            //app.MapControllerRoute(
            //    name: "default",
            //    pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapDefaultControllerRoute();

            app.Run();
        }
    }
}