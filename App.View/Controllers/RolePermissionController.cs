using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.View.Controllers
{
    public class RolePermissionController : Controller
    {
        // GET: RolePermissionController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RolePermissionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RolePermissionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RolePermissionController/Create
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

        // GET: RolePermissionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RolePermissionController/Edit/5
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

        // GET: RolePermissionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RolePermissionController/Delete/5
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
