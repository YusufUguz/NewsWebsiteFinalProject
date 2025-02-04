using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewsWebsiteFinalProject.Models;

public class CategoryViewComponent : ViewComponent
{
    private readonly NewsWebsiteContext _context;

    public CategoryViewComponent(NewsWebsiteContext context)
    {
        _context = context;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var categories = await _context.Categories.ToListAsync();
        return View(categories);
    }
}