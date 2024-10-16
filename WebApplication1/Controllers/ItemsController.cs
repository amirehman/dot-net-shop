using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;


public class ItemsController : Controller
{

    public IActionResult Overview()
    {
        var item = new Item() { Name = "keyboard" };
        return View(item);
    }

    public IActionResult Edit(int id)
    {
        return Content("ID " + id);
    }

    
}