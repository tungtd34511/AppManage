using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.View.Controllers
{
    public class ActivityLogController : Controller
    {
        // GET: ActivityLogController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ActivityLogController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ActivityLogController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ActivityLogController/Create
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

        // GET: ActivityLogController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ActivityLogController/Edit/5
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

        // GET: ActivityLogController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ActivityLogController/Delete/5
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
