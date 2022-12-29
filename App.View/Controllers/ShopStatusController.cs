using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.View.Controllers
{
    public class ShopStatusController : Controller
    {
        // GET: ShopStatusController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ShopStatusController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ShopStatusController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShopStatusController/Create
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

        // GET: ShopStatusController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ShopStatusController/Edit/5
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

        // GET: ShopStatusController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ShopStatusController/Delete/5
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
