using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MybookWeb.Dtos;
using MybookWeb.Entities;
using MybookWeb.Interface;
using MybookWeb.Models;

namespace MybookWeb.Controllers
{
    public class AppRoleController : Controller
    {
        private IRole _role;
        public AppRoleController(IRole r)
        {
            _role = r;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await _role.GetAll();
            if (model != null)
            {
                return View(model);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RoleDto registerRole)
        {
            ApplicationRole r = new ApplicationRole();
            r.Name = registerRole.RoleName;

            var newRole = await _role.CreateRole(r);

            if (newRole)
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
        public async Task<IActionResult> Delete(String id)
        {
           
            var deleteRole = await _role.Delete(id);
            if (deleteRole)
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
