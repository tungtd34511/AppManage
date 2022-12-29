using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.View.Controllers
{
    public class PostLayoutController : Controller
    {
        // GET: PostLayoutController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PostLayoutController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PostLayoutController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PostLayoutController/Create
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

        // GET: PostLayoutController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PostLayoutController/Edit/5
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

        // GET: PostLayoutController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PostLayoutController/Delete/5
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
