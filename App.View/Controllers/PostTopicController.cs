using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.View.Controllers
{
    public class PostTopicController : Controller
    {
        // GET: PostTopicController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PostTopicController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PostTopicController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PostTopicController/Create
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

        // GET: PostTopicController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PostTopicController/Edit/5
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

        // GET: PostTopicController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PostTopicController/Delete/5
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
