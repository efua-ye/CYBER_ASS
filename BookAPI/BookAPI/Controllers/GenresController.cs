using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookAPI.Entities;
using BookAPI.Interface;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace BookAPI.Controllers
{

    [Route("api/Genre")]
    [ApiController]
  //  [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    public class GenresController : ControllerBase
    {
        private IGenre _genre;
        public GenresController(IGenre genre)
        {
            _genre = genre;
        }
        [HttpPost("AddedGenres")]
        public void Post([FromBody] Genre genre)
        {
            _genre.Add(genre);
        }
        [HttpPost("AddGenre")]
        public async Task<IActionResult> AddBook([FromBody] Genre genre)
        {
            var createBook = await _genre.AddAsync(genre);

            if (createBook)
            {
                return Ok("Genre Created");
            }
            else
            {
                return BadRequest(new { message = "Genre details cannot be created" });
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var users = await _genre.GetAll();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var user = await _genre.GetById(id);
            return Ok(user);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Genre genre)
        {
            genre.Id = id;
            var updateGenre = await _genre.Update(genre);

            if (updateGenre)
            {
                return Ok("Genre Updated");
            }
            else
            {
                return BadRequest(new { message = "Unable to update Genre details" });
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleteGenre = await _genre.Delete(id);
            if (deleteGenre)
            {
                return Ok("Genre Deleted");
            }
            else
            {
                return BadRequest(new { message = "Unable to delete Genre details" });
            }
        }


    }
}