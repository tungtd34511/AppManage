using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.View.Controllers
{
    public class ReadedPostController : Controller
    {
        // GET: ReadedPostController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ReadedPostController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReadedPostController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReadedPostController/Create
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

        // GET: ReadedPostController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReadedPostController/Edit/5
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

        // GET: ReadedPostController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReadedPostController/Delete/5
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
