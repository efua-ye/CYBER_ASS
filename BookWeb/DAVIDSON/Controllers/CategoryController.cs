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
    public class CategoryController : Controller
    {
        private ICategory _category;
        public CategoryController(ICategory category)
        {
            _category = category;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await _category.GetAll();
            if (model != null)
            {
                return View(model);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Category c)
        {
            var createCategory = await _category.AddAsync(c);

            if (createCategory)
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
            var deletecategory = await _category.Delete(id);
            if (deletecategory)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
