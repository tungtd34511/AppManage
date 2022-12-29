using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.View.Controllers
{
    public class ShopProductController : Controller
    {
        // GET: ShopProductController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ShopProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ShopProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShopProductController/Create
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

        // GET: ShopProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ShopProductController/Edit/5
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

        // GET: ShopProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ShopProductController/Delete/5
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
