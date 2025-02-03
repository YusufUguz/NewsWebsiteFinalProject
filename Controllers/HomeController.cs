using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewsWebsiteFinalProject.Models;

namespace NewsWebsiteFinalProject.Controllers;

public class HomeController : Controller
{
    private readonly NewsWebsiteContext _context;

    public HomeController(NewsWebsiteContext context){
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        List<News> news = await _context.News.Include(n => n.Category).ToListAsync();
        List<Category> categories = await _context.Categories.ToListAsync();
        ViewData["Categories"] = categories;
        return View(news);
    }

}
