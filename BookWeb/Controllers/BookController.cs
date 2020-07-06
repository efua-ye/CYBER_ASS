using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookWeb.Models;
using BookWeb.Interface;
using BookWeb.Entities;
using BookWeb.Enums;
using Microsoft.AspNetCore.Identity;

namespace BookWeb.Controllers
{
    public class BookController : BaseController
    {
        private readonly UserManager<ApplicationUser> _userManager;

        private IBook _book;
        public BookController(IBook book, UserManager<ApplicationUser> userManager)
        {
            _book = book;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _book.GetAll();

            if (model != null)
                return View(model);
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Book book)
        {
            book.CreatedBy = _userManager.GetUserName(User);
            book.DateCreated = DateTime.Now;
            var createBook = await _book.AddAsync(book);

            if (createBook)
            {
                Alert("Book created successfully.", NotificationType.success);

                return RedirectToAction("Index");
            }
            else
            {
                Alert("Book not created!", NotificationType.error);

            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var editBook = await _book.GetById(id);

            if (editBook == null)
            {
                return RedirectToAction("Index");
            }
            return View(editBook);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Book book)
        {
           
            var editBook = await _book.Update(book);

            if (editBook && ModelState.IsValid)
            {
                Alert("Book edited successfully.", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("Book not edited!", NotificationType.error);
            }
            return View();
        }

        public async Task<IActionResult> Delete(int id)
        {
            var deleteBook = await _book.Delete(id);
            if (deleteBook)
            {
                return RedirectToAction("Index");
            }
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
