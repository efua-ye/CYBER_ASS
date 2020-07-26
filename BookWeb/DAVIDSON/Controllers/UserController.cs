using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MybookWeb.Dtos;
using MybookWeb.Entities;
using MybookWeb.Interface;
using MybookWeb.Models;

namespace MybookWeb.Controllers
{
    public class UserController : Controller
    {
        private IUser _userService;
        private IConfiguration _config;

        public UserController(IUser userService, IConfiguration config)
        {
            _userService = userService;
            _config = config;
        }
        // GET: /<controller>/

        [HttpPost]
        public IActionResult Create([FromBody] UserDto userDto)
        {
            // map dto to entity
            // var userdto = _mapper.Map<User>(userDto);

            var user = new User
            {
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                Email = userDto.Email,
                Username = userDto.Username,
                PhoneNo = userDto.PhoneNo
            };
            try
            {
                // save 
                var userCreated = _userService.Create(user, userDto.Password);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                // return error message if there was an exception
                return View();
            }
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await _userService.GetAll();
            if (model != null)
            {
                return View(model);
            }
            return View();
        }

       /* [HttpPost]
        public async Task<IActionResult> Create(Book b)
        {
            var createBook = await _book.AddAsync(b);

            if (createBook)
            {
                return RedirectToAction("Index");
            }
            return View();
        }*/
       
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var deleteUser = await _userService.Delete(id);
            if (deleteUser)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
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
