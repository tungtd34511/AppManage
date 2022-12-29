using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.View.Controllers
{
    public class FeaturedPostController : Controller
    {
        // GET: FeaturedPostController
        public ActionResult Index()
        {
            return View();
        }

        // GET: FeaturedPostController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FeaturedPostController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FeaturedPostController/Create
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

        // GET: FeaturedPostController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FeaturedPostController/Edit/5
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

        // GET: FeaturedPostController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FeaturedPostController/Delete/5
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
