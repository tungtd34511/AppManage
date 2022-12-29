using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.View.Controllers
{
    public class ProductBrandController : Controller
    {
        // GET: ProductBrandController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProductBrandController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductBrandController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductBrandController/Create
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

        // GET: ProductBrandController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductBrandController/Edit/5
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

        // GET: ProductBrandController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductBrandController/Delete/5
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
