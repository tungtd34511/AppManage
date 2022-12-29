﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.View.Controllers
{
    public class PromotionController : Controller
    {
        // GET: PromotionController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PromotionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PromotionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PromotionController/Create
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

        // GET: PromotionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PromotionController/Edit/5
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

        // GET: PromotionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PromotionController/Delete/5
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
