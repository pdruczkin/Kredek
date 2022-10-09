using Microsoft.AspNetCore.Mvc;
using PatrykRuczkinLab5PracDom.Services;

namespace PatrykRuczkinLab5PracDom.Controllers
{
    public class CategoriesController : Controller
    {
        //service responisble to make operations on database
        private readonly ICategoryService _service;

        public CategoriesController(ICategoryService service)
        {
            _service = service;
        }


        /// <summary>
        /// Function, which get category by its name and provide it to view
        /// </summary>
        /// <param name="categoryName"></param>
        /// <returns></returns>
        public IActionResult Index(string categoryName)
        {
            var category = _service.GetByName(categoryName);


            return View(category);
        }



    }
}