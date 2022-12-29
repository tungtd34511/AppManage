using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.View.Controllers
{
    public class OrderStatusController : Controller
    {
        // GET: OrderStatusController
        public ActionResult Index()
        {
            return View();
        }

        // GET: OrderStatusController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrderStatusController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderStatusController/Create
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

        // GET: OrderStatusController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderStatusController/Edit/5
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

        // GET: OrderStatusController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderStatusController/Delete/5
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
