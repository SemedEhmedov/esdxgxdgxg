using Microsoft.AspNetCore.Mvc;

namespace WebApplication6.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class DashBoard : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
