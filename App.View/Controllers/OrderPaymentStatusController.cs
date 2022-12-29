using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.View.Controllers
{
    public class OrderPaymentStatusController : Controller
    {
        // GET: OrderPaymentStatusController
        public ActionResult Index()
        {
            return View();
        }

        // GET: OrderPaymentStatusController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrderPaymentStatusController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderPaymentStatusController/Create
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

        // GET: OrderPaymentStatusController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderPaymentStatusController/Edit/5
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

        // GET: OrderPaymentStatusController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderPaymentStatusController/Delete/5
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
