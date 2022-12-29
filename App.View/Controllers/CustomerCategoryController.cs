using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.View.Controllers
{
    public class CustomerCategoryController : Controller
    {
        // GET: CustomerCategoryController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CustomerCategoryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerCategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerCategoryController/Create
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

        // GET: CustomerCategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerCategoryController/Edit/5
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

        // GET: CustomerCategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerCategoryController/Delete/5
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
