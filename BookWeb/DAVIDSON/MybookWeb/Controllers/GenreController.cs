using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MybookWeb.Entities;
using MybookWeb.Interface;
using MybookWeb.Models;

namespace MybookWeb.Controllers
{
    public class GenreController : BaseController
    {
        private IGenre _genre;
        public GenreController(IGenre gen)
        {
            _genre = gen;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await _genre.GetAll();
            if (model != null)
            {
                return View(model);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Genre g)
        {
            var createGenre = await _genre.AddAsync(g);

            if (createGenre)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var deleteGenre = await _genre.Delete(id);
            if (deleteGenre)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Genre g)
        {
            var editGenre = await _genre.Update(g);
            if (editGenre && ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var editGenre = await _genre.GetById(id);
            if (editGenre == null)
            {
                return RedirectToAction("Index");
            }
            return View(editGenre);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
