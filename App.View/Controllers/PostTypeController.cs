using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.View.Controllers
{
    public class PostTypeController : Controller
    {
        // GET: PostTypeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PostTypeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PostTypeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PostTypeController/Create
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

        // GET: PostTypeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PostTypeController/Edit/5
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

        // GET: PostTypeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PostTypeController/Delete/5
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
