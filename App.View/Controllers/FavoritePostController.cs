using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.View.Controllers
{
    public class FavoritePostController : Controller
    {
        // GET: FavoritePostController
        public ActionResult Index()
        {
            return View();
        }

        // GET: FavoritePostController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FavoritePostController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FavoritePostController/Create
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

        // GET: FavoritePostController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FavoritePostController/Edit/5
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

        // GET: FavoritePostController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FavoritePostController/Delete/5
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
