using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.View.Controllers
{
    public class PromotionMetumController : Controller
    {
        // GET: PromotionMetumController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PromotionMetumController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PromotionMetumController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PromotionMetumController/Create
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

        // GET: PromotionMetumController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PromotionMetumController/Edit/5
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

        // GET: PromotionMetumController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PromotionMetumController/Delete/5
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
