using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookAPI.Entities;
using BookAPI.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace BookAPI.Controllers

{

    [Route("api/Reader")]
    [ApiController]
  //  [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    public class ReaderController : ControllerBase
    {
        private IReader _reader;
        public ReaderController(IReader reader)
        {
            _reader = reader;
        }
        [HttpPost("AddedReader")]
        public void Post([FromBody] Reader reader)
        {
            _reader.Add(reader);
        }
        [HttpPost("AddReader")]
        public async Task<IActionResult> AddReader([FromBody] Reader reader)
        {
            var createReader = await _reader.AddAsync(reader);

            if (createReader)
            {
                return Ok("Reader Created");
            }
            else
            {
                return BadRequest(new { message = "Reader details cannot be created" });
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var users = await _reader.GetAll();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var user = await _reader.GetById(id);
            return Ok(user);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Reader reader)
        {
            reader.Id = id;
            var updateReader = await _reader.Update(reader);

            if (updateReader)
            {
                return Ok("Reader Updated");
            }
            else
            {
                return BadRequest(new { message = "Unable to update Reader details" });
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleteReader = await _reader.Delete(id);
            if (deleteReader)
            {
                return Ok("Reader Deleted");
            }
            else
            {
                return BadRequest(new { message = "Unable to delete Reader details" });
            }
        }


    }
}