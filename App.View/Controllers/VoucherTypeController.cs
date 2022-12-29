using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.View.Controllers
{
    public class VoucherTypeController : Controller
    {
        // GET: VoucherTypeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: VoucherTypeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VoucherTypeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VoucherTypeController/Create
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

        // GET: VoucherTypeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VoucherTypeController/Edit/5
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

        // GET: VoucherTypeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VoucherTypeController/Delete/5
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
