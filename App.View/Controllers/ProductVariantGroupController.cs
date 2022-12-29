using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.View.Controllers
{
    public class ProductVariantGroupController : Controller
    {
        // GET: ProductVariantGroupController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProductVariantGroupController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductVariantGroupController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductVariantGroupController/Create
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

        // GET: ProductVariantGroupController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductVariantGroupController/Edit/5
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

        // GET: ProductVariantGroupController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductVariantGroupController/Delete/5
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
