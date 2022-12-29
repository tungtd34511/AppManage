using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.View.Controllers
{
    public class PostPublishStatusController : Controller
    {
        // GET: PostPublishStatusController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PostPublishStatusController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PostPublishStatusController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PostPublishStatusController/Create
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

        // GET: PostPublishStatusController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PostPublishStatusController/Edit/5
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

        // GET: PostPublishStatusController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PostPublishStatusController/Delete/5
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
