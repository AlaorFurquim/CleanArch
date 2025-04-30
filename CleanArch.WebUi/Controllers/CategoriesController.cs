using CleanArch.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.WebUi.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryServices _categoriesServices;
        public CategoriesController(ICategoryServices categoriesServices)
        {
            _categoriesServices = categoriesServices;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var categories = await _categoriesServices.GetCategories();
            return View(categories);
        }
    }
}
