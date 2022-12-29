using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.View.Controllers
{
    public class VoucherMetumController : Controller
    {
        // GET: VoucherMetumController
        public ActionResult Index()
        {
            return View();
        }

        // GET: VoucherMetumController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VoucherMetumController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VoucherMetumController/Create
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

        // GET: VoucherMetumController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VoucherMetumController/Edit/5
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

        // GET: VoucherMetumController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VoucherMetumController/Delete/5
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
