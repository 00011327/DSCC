using LibraryUI.Models;
using LibraryUI.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace LibraryUI.Controllers
{
    public class BooksController : Controller
    {
        private readonly IRepository<Book> _bookRepository;

        public BooksController(IRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }
        // GET: BooksController
        public ActionResult Index()
        {
            var data = _bookRepository.GetAll();
            return View(data);
        }

        // GET: BooksController/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var book = _bookRepository.GetAll()
                .FirstOrDefault(m => m.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // GET: BooksController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BooksController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("ISBN,Title,Author")] Book book)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _bookRepository.Create(book);
                }
                return RedirectToAction(nameof(this.Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BooksController/Edit/5
        public ActionResult Edit(int id)
        {
            var book = _bookRepository.GetById(id);
            if (book == null)
            {
                return NotFound(nameof(book));
            }
            return View(book);
        }

        // POST: BooksController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                _bookRepository.Update(book);
                return RedirectToAction("Index");
            }
            return View("Edit", book);
        }

        // GET: BooksController/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = _bookRepository.GetAll()
                .FirstOrDefault(m => m.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: BooksController/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var car = _bookRepository.GetAll().FirstOrDefault(x => x.Id == id);
            if (car == null)
            {
                return NotFound();
            }
            _bookRepository.Delete(id);
            return RedirectToAction(nameof(this.Index));
        }
    }
}
