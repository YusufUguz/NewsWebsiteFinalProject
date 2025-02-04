using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewsWebsiteFinalProject.Models;

namespace NewsWebsiteFinalProject.Controllers{
    public class CategorizedNewsController : Controller {
        private readonly NewsWebsiteContext _context;

        public CategorizedNewsController(NewsWebsiteContext context){
            _context = context;
        }

        public async Task<IActionResult> Index(int categoryID){
            var news = await _context.News.Where(news => news.CategoryID == categoryID).ToListAsync();
            ViewBag.Categories = _context.Categories.ToList();
            return View(news);
        }
    }
}