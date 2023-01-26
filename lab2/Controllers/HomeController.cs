using lab2.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab2.Controllers;

public class HomeController : Controller
{
    // GET
    [HttpGet]
    public IActionResult Index()
    {
        return View(new TipModel());
    }

    [HttpPost]
    public IActionResult Index(TipModel model)
    {
        if (ModelState.IsValid)
        {
            model.CalculateTip();
        }
        
        return View(model);
    }
}