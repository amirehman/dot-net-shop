using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class CategoryController : Controller
{ 

    private readonly ApplicationDbContext _db;
    public CategoryController(ApplicationDbContext db)
    {
        _db = db;
    }
    public IActionResult Index()
    {
        List<Category> objCategoryList = _db.Categories.ToList();
        return View(objCategoryList);
    }

    public IActionResult Create()
    {
        return View();
    }   
    
    [HttpPost]
    public IActionResult Create(Category category)
    {

        if (category.Name == category.DisplayOrder.ToString())
        {
            ModelState.AddModelError("name", "The name and display order must be different.");
        }
        
        if (ModelState.IsValid)
        {
            _db.Categories.Add(category);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        return View();
    }
    
}