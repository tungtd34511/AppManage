using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.View.Controllers
{
    public class PostCommentStatusController : Controller
    {
        // GET: PostCommentStatusController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PostCommentStatusController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PostCommentStatusController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PostCommentStatusController/Create
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

        // GET: PostCommentStatusController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PostCommentStatusController/Edit/5
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

        // GET: PostCommentStatusController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PostCommentStatusController/Delete/5
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
