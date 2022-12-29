using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.View.Controllers
{
    public class ShopTypeController : Controller
    {
        // GET: ShopTypeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ShopTypeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ShopTypeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShopTypeController/Create
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

        // GET: ShopTypeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ShopTypeController/Edit/5
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

        // GET: ShopTypeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ShopTypeController/Delete/5
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
