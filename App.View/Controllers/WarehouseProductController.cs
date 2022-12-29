using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.View.Controllers
{
    public class WarehouseProductController : Controller
    {
        // GET: WarehouseProductController
        public ActionResult Index()
        {
            return View();
        }

        // GET: WarehouseProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WarehouseProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WarehouseProductController/Create
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

        // GET: WarehouseProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WarehouseProductController/Edit/5
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

        // GET: WarehouseProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WarehouseProductController/Delete/5
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
