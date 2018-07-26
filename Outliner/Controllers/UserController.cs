using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Outliner.Models;
using Outliner.ViewModels;

namespace Outliner.Controllers
{
    public class UserController : Controller
    {

        // GET: User
        public ActionResult Index(string message)
        {
            ViewBag.message = message;
            return View();
        }

        //Add
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Add(AddUserViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            model.Add();
            string messageString = $"Welcome {model.Username}";
            //return Redirect($"Index?message={messageString}");
            return RedirectToAction("Index", new { message = messageString });
        }

        /* // GET: User/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        } */
    }
}