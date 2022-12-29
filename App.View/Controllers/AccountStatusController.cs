using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.View.Controllers
{
    public class AccountStatusController : Controller
    {
        // GET: AccountStatusController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AccountStatusController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AccountStatusController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccountStatusController/Create
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

        // GET: AccountStatusController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AccountStatusController/Edit/5
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

        // GET: AccountStatusController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AccountStatusController/Delete/5
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
