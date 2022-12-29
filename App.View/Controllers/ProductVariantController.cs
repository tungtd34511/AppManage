using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.View.Controllers
{
    public class ProductVariantController : Controller
    {
        // GET: ProductVariantController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProductVariantController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductVariantController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductVariantController/Create
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

        // GET: ProductVariantController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductVariantController/Edit/5
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

        // GET: ProductVariantController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductVariantController/Delete/5
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
