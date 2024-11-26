using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication6.DAL;

namespace WebApplication6.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class ProductController : Controller
    {
        AppDBContext context;
        public ProductController(AppDBContext appDBcontext)
        {
            context = appDBcontext;
        }
        public async Task<IActionResult> Index()
        {
            var Products = await context.Products.ToListAsync();
            return View(Products);
        }
    }
}
