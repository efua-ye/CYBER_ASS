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
    public class BookController:BaseController    
    {
        private IBook _book;
        public BookController(IBook book)
        {
            _book = book;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await _book.GetAll();
            if (model != null)
            {
                return View(model);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Book b)
        {
            var createBook = await _book.AddAsync(b);
            if (createBook)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

       // [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var deleteBook = await _book.Delete(id);
            if (deleteBook)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Book b)
        {
            var editBook = await _book.Update(b);
            if (editBook && ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var editAuthor = await _book.GetById(id);
            if (editAuthor == null)
            {
                return RedirectToAction("Index");
            }
            return View(editAuthor);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
