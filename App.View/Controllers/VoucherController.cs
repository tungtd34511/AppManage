using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.View.Controllers
{
    public class VoucherController : Controller
    {
        // GET: VoucherController
        public ActionResult Index()
        {
            return View();
        }

        // GET: VoucherController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VoucherController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VoucherController/Create
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

        // GET: VoucherController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VoucherController/Edit/5
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

        // GET: VoucherController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VoucherController/Delete/5
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
