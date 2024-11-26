using Microsoft.EntityFrameworkCore;
using WebApplication6.DAL;

namespace WebApplication6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDBContext>(opt =>
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("default"));
            });
            var app = builder.Build();
            app.MapControllerRoute(
                name: "area",
                pattern: "{area:exists}/{controller=DashBoard}/{action=index}"
                );
            app.MapControllerRoute(
                 name: "default",
                 pattern: "{controller=home}/{action=index}"
                 );
            app.UseStaticFiles();
            app.Run();
        }
    }
}
