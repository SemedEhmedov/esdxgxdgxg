using Microsoft.AspNetCore.Mvc;
using WebApplication6.DAL;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        AppDBContext context;
        public HomeController(AppDBContext appDBContext)
        {
            context = appDBContext;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
