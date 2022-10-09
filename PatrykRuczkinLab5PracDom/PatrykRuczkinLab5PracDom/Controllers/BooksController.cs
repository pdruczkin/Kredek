using Microsoft.AspNetCore.Mvc;
using PatrykRuczkinLab5PracDom.Models.Dtos;
using PatrykRuczkinLab5PracDom.Services;

namespace PatrykRuczkinLab5PracDom.Controllers
{
    public class BooksController : Controller
    {
        //service responisble to make operations on database
        private readonly IBooksService _booksService;

        public BooksController(IBooksService booksService)
        {
            _booksService = booksService;
        }


        /// <summary>
        /// Main function, get and provides all books to view
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {

            var booksViewModels = _booksService.GetAll();


            return View(booksViewModels);
        }

        /// <summary>
        /// Function which get and provides book details to view
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Details(int id)
        {
            var bookDetailsViewModel = _booksService.GetById(id);

            return View(bookDetailsViewModel);
        }


        /// <summary>
        /// Function redirect to create form
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            return View();
        }
        /// <summary>
        /// Function which add book and come back to main view
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create(AddBookDto dto)
        {
            _booksService.Add(dto);

            return RedirectToAction("Index");
        }

        /// <summary>
        /// Function which delete book and come back to main view
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Delete(int id)
        {
            _booksService.Delete(id);


            return RedirectToAction("Index");
        }

        /// <summary>
        /// Function, which get book details by id and provides it to edit form
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Edit(int id)
        {
            var book = _booksService.GetById(id);

            if (book == null)
            {
                return NotFound();
            }


            return View(book);
        }

        /// <summary>
        /// Function, which edit certain book and come back to main view
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Edit(EditBookDto dto)
        {

            _booksService.Edit(dto);


            return RedirectToAction("Index");
        }
    }
}