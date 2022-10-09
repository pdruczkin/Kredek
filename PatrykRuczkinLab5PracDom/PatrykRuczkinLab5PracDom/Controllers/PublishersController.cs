using Microsoft.AspNetCore.Mvc;
using PatrykRuczkinLab5PracDom.Services;

namespace PatrykRuczkinLab5PracDom.Controllers
{
    public class PublishersController : Controller
    {
        //service responisble to make operations on database
        private readonly IPublisherService _service;

        public PublishersController(IPublisherService service)
        {
            _service = service;
        }

        /// <summary>
        /// Function, which gets all publishers and provides it to view
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var publishers = _service.GetAll();


            return View(publishers);
        }
        /// <summary>
        /// Function, which gets publisher's details and provides it to view
        /// </summary>
        /// <returns></returns>
        public IActionResult Details(int id)
        {
            var publisher = _service.GetById(id);


            return View(publisher);
        }

    }
}