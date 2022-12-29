using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.View.Controllers
{
    public class PostMetumController : Controller
    {
        // GET: PostMetumController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PostMetumController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PostMetumController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PostMetumController/Create
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

        // GET: PostMetumController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PostMetumController/Edit/5
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

        // GET: PostMetumController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PostMetumController/Delete/5
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
