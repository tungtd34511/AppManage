using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.View.Controllers
{
    public class TransactionTypeController : Controller
    {
        // GET: TransactionTypeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TransactionTypeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TransactionTypeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TransactionTypeController/Create
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

        // GET: TransactionTypeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TransactionTypeController/Edit/5
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

        // GET: TransactionTypeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TransactionTypeController/Delete/5
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
