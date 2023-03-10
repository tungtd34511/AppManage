using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.View.Controllers
{
    public class TransactionStatusController : Controller
    {
        // GET: TransactionStatusController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TransactionStatusController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TransactionStatusController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TransactionStatusController/Create
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

        // GET: TransactionStatusController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TransactionStatusController/Edit/5
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

        // GET: TransactionStatusController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TransactionStatusController/Delete/5
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
