using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MybookWeb.Interface;
using MybookWeb.Models;
using MybookWeb.Entities;
using Publisher = MybookWeb.Entities.Publisher;

namespace MybookWeb.Controllers
{
    public class PublisherController : Controller
    {
        private IPublisher _pub;
        public PublisherController(IPublisher pub)
        {
            _pub = pub;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await _pub.GetAll();
            if (model != null)
            {
                return View(model);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Publisher p)
        {
            var createPub = await _pub.AddAsync(p);

            if (createPub)
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
            var deletePub = await _pub.Delete(id);
            if (deletePub)
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
