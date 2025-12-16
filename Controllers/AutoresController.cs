using books.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace books.Controllers
{
    public class AutoresController : Controller
    {
        // GET: AutoresController
        public ActionResult Index()
        {
            var autores = new List<AutorViewModel>
            {
                new AutorViewModel {Id =1, FirstName = "Mike", LastName = "Joseph"},
                new AutorViewModel {Id =2, FirstName = "Gabriel", LastName = "Hernandez"},
                new AutorViewModel {Id =2, FirstName = "Ramirez", LastName = "Cruz"},
                new AutorViewModel {Id =2, FirstName = "Maria", LastName = "Sanchez"},
                new AutorViewModel {Id =2, FirstName = "Dilan", LastName = "Contreras"},
            };
            return View(autores);
        }

        // GET: AutoresController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AutoresController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AutoresController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AutoresController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AutoresController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AutoresController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AutoresController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
