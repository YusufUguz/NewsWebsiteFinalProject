using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NewsWebsiteFinalProject.Models;

namespace NewsWebsiteFinalProject.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

}
