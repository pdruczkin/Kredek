using System.Diagnostics.Eventing.Reader;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatrykRuczkinLab4PracDom.Models;
using PatrykRuczkinLab4PracDom.Services;

namespace PatrykRuczkinLab4PracDom.Controllers
{
    public class AccountController : Controller
    {
        private IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }


        /// <summary>
        /// Endpoint shows form to register
        /// </summary>
        /// <returns></returns>
        public IActionResult Register()
        {
            return View();
        }

        /// <summary>
        /// Endpoint register user
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Register(RegisterUserDto dto)
        {
            _accountService.Register(dto);
            return RedirectToAction("Login");
        }

        /// <summary>
        /// Endpoint shows login form
        /// </summary>
        /// <returns></returns>
        public IActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// Endpoint login user
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Login(LoginUserDto dto)
        {
            var username = _accountService.Login(dto);
            HttpContext.Session.SetString("username",username);

            return RedirectToAction("Index", "Home");
        }

    }
}
