using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PatrykRuczkinLab4PracDom.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using PatrykRuczkinLab4PracDom.Services;

namespace PatrykRuczkinLab4PracDom.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
            
        }


        /// <summary>
        /// Main endpoint shows all recipes
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var username = HttpContext.Session.GetString("username");
            if (string.IsNullOrEmpty(username))
            {
                return RedirectToAction("Login", "Account");
            }

            ViewBag.username = username;
            var recipes = _homeService.GetAllRecipes();
            return View(recipes);
        }

        /// <summary>
        /// Endpoint shows details of one recipe
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult RecipeById(int id)
        {
            var recipe = _homeService.GetRecipeById(id);
            return View(recipe);
        }

        /// <summary>
        /// Endpoint shows form to create recipe
        /// </summary>
        /// <returns></returns>
        public IActionResult CreateRecipe()
        {
            return View();
        }

        /// <summary>
        /// Endpoint creates recipe
        /// </summary>
        /// <param name="recipe"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CreateRecipe(CreateRecipeDto recipe)
        {
            _homeService.AddRecipe(recipe);

            return RedirectToAction("Index");
        }

        /// <summary>
        /// Error endpoint
        /// </summary>
        /// <returns></returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }




    }
}
