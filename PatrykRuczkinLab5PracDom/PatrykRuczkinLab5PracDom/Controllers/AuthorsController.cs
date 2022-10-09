using Microsoft.AspNetCore.Mvc;
using PatrykRuczkinLab5PracDom.Services;

namespace PatrykRuczkinLab5PracDom.Controllers
{
    public class AuthorsController : Controller
    {
        //service responisble to make operations on database
        private readonly IAuthorsService _service;

        public AuthorsController(IAuthorsService service)
        {
            _service = service;
        }

        /// <summary>
        /// Function, which get all authors by their first and last names
        /// </summary>
        /// <param name="fullName"></param>
        /// <returns></returns>
        public IActionResult Index(string fullName)
        {
            var authors = _service.GetByFullName(fullName);
            

            return View(authors);
        }



    }
}