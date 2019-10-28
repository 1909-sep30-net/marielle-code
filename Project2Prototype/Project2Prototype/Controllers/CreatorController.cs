using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project2Prototype.Library;
using System.Collections.Generic;

namespace Project2Prototype.Controllers
{
    public class CreatorController : Controller
    {
        private IRepository _repository;

        public CreatorController(IRepository repository)
        {
            _repository = repository;
        }

        // GET: Creator

        public ActionResult Index()
        {
            List<Creator> creators = _repository.GetCreators();
            return View(creators);
        }

        // GET: Creator/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Creator/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Creator/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Creator c = new Creator()
                {
                    FirstName = collection["FirstName"],
                    LastName = collection["LastName"],
                    PhoneNumber = int.Parse(collection["PhoneNumber"])
                };
                _repository.AddCreator(c);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Creator/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Creator/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: Creator/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Creator/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
        }
    }
}