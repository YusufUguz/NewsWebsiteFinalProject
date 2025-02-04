using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewsWebsiteFinalProject.Models;

namespace NewsWebsiteFinalProject.Controllers
{
    public class NewsController : Controller
    {

        private readonly NewsWebsiteContext _context;

        public NewsController(NewsWebsiteContext context)
        {
            _context = context;

        }

        [HttpGet]
        public IActionResult Create()
        {   
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(News model)
        {

            _context.News.Add(model);
            await _context.SaveChangesAsync();
            ViewBag.Categories = _context.Categories.ToList();
            return RedirectToAction("Index","Home");
        }

        public async Task<IActionResult> Edit(int? id){
            ViewBag.Categories = _context.Categories.ToList();
            if(id == null){
                return NotFound();
            }
            var news = await _context.News.FindAsync(id);

            if(news == null){
                return NotFound();
            }
            return View(news);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Edit(int id, News model){
            ViewBag.Categories = _context.Categories.ToList();
            if(id != model.NewsID){
                return NotFound();
            }

            if(ModelState.IsValid){
                try
                {
                    _context.Update(model);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if(!_context.News.Any(o=>o.NewsID == model.NewsID)){
                        return NotFound();
                    }
                    else{
                        throw;
                    }
                }
                return RedirectToAction("Index","Home");
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult>Delete(int? id){
            if(id == null){
                return NotFound();
            }

            var news = await _context.News.FindAsync(id);

            if(news == null){
                return NotFound();
            }

            return View(news);
        }

        [HttpPost]
        public async Task<IActionResult>Delete([FromForm]int id){
            var news = await _context.News.FindAsync(id);
            if(news == null){
                return NotFound();
            }
            _context.News.Remove(news);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index","Home");
        }

    }
}