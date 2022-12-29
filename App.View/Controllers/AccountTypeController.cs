using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.View.Controllers
{
    public class AccountTypeController : Controller
    {
        // GET: AccountTypeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AccountTypeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AccountTypeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccountTypeController/Create
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

        // GET: AccountTypeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AccountTypeController/Edit/5
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

        // GET: AccountTypeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AccountTypeController/Delete/5
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
