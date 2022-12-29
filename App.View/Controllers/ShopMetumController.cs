using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.View.Controllers
{
    public class ShopMetumController : Controller
    {
        // GET: ShopMetumController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ShopMetumController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ShopMetumController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShopMetumController/Create
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

        // GET: ShopMetumController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ShopMetumController/Edit/5
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

        // GET: ShopMetumController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ShopMetumController/Delete/5
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
