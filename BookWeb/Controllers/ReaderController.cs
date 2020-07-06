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
    public class ReaderController : BaseController
    {
        private IReader _reader;
        private readonly UserManager<ApplicationUser> _userManager;

        public ReaderController(IReader reader, UserManager<ApplicationUser> userManager)
        {
            _reader = reader;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _reader.GetAll();

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
        public async Task<IActionResult> Create(Reader reader)
        {
           
            var createReader = await _reader.AddAsync(reader);

            if (createReader)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var editReader = await _reader.GetById(id);

            if (editReader == null)
            {
                return RedirectToAction("Index");
            }
            return View(editReader);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(Reader reader)
        {
            var editReader = await _reader.Update(reader);

            if (editReader && ModelState.IsValid)
            {
                Alert("Reader edited successfully.", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("Reader not edited!", NotificationType.error);
            }
            return View();
        }

        public async Task<IActionResult> Delete(int id)
        {
            var deleteReader = await _reader.Delete(id);
            if (deleteReader)
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
