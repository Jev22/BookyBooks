using BookWeb.Data;
using BookWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            // var objCategoryList = _db.Category.ToList();
            // I stedet for at bruge var, så foreslåes det at bruge IEnumerable<> da det er strongly typed
            IEnumerable<Category> objCategoryList = _db.Category.ToList(); //Da vi bruger IEnumerable, vil dette stadig virke uden .ToList();
            //IEnumerable<Category> vil også være vores "model" som vi kalder i category/index.cshtml
            return View(objCategoryList);
        }
    }
}
