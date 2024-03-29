﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokeApp.BusinessLogic;

namespace PokeApp.WebApp.Controllers
{
    public class PokemonController : Controller
    {
        private readonly IRepository _repository;

        public PokemonController(IRepository repository)
        {
            _repository = repository;
        }

        // GET: Pokemon
        public async Task<ActionResult> Index()
        {
            // to get the pokemon, i need some IRepository.
            // so, instead of just writing "new Repository()",
            // i will use "constructor injection pattern"
            IEnumerable<Pokemon> pokemon = await _repository.GetAllPokemonAsync();

            return View(pokemon);
        }

        // GET: Pokemon/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pokemon/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pokemon/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                
                _repository.AddPokemonAsync(new BusinessLogic.Pokemon()
                {
                    Name = collection["Name"],
                    Height = int.Parse(collection["Height"]),
                    Weight = int.Parse(collection["Weight"])

                });

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Pokemon/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pokemon/Edit/5
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

        // GET: Pokemon/Delete/5
        public ActionResult Delete(int id)
        {
            
            return View(_repository.GetPokemon(id));
        }

        // POST: Pokemon/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                _repository.DeletePokemon(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
