using Bulkybook.Data;
using Bulkybook.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bulkybook.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationdbContext _db;

        public CategoryController(ApplicationdbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList = _db.Categories;
            return View(objCategoryList);
        }
    }
}
