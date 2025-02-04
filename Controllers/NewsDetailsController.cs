using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewsWebsiteFinalProject.Models;

namespace NewsWebsiteFinalProject.Controllers{
    public class NewsDetailsController : Controller {
        private readonly NewsWebsiteContext _context;

        public NewsDetailsController(NewsWebsiteContext context){
            _context = context;
        }

        public async Task<IActionResult> Index(int newsID){
            var news = await _context.News.Where(news => news.NewsID == newsID).FirstOrDefaultAsync();
            ViewBag.Categories = _context.Categories.ToList();
            return View(news);
        }
    }
}