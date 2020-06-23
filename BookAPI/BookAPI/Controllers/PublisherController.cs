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
    [Route("api/Publisher")]
    [ApiController]
  //  [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    public class PublisherController : ControllerBase
    {
        private IPublisher _publisher;
        public PublisherController(IPublisher publisher)
        {
            _publisher = publisher;
        }

        [HttpPost("AddedPublisher")]
        public void Post([FromBody] Publisher publisher)
        {
            _publisher.Add(publisher);
        }

        [HttpPost("AddPublisher")]
        public async Task<IActionResult> AddPublisher([FromBody] Publisher publisher)
        {
            var createPublisher = await _publisher.AddAsync(publisher);

            if (createPublisher)
            {
                return Ok("Publisher Created");
            }
            else
            {
                return BadRequest(new { message = "Unable to create Publisher details" });
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var users = await _publisher.GetAll();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var user = await _publisher.GetById(id);
            return Ok(user);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Publisher publisher)
        {
            publisher.Id = id;
            var updatePublisher = await _publisher.Update(publisher);

            if (updatePublisher)
            {
                return Ok("Publisher Updated");
            }
            else
            {
                return BadRequest(new { message = "Unable to update Publisher details" });
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deletePublisher = await _publisher.Delete(id);
            if (deletePublisher)
            {
                return Ok("Publisher Deleted");
            }
            else
            {
                return BadRequest(new { message = "Unable to delete Publisher details" });
            }
        }
    }


}
