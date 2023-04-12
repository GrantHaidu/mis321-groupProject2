using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using api.Models;
using api.Database;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public List<Cars> AllSongs = new List<Cars>();
        // GET: api/Course
        [HttpGet]
        public List<Cars> Get()
        {

        }

        // GET: api/Songs/5
        [HttpGet("{id}", Name = "Get")]
       

        // POST: api/Songs
        [HttpPost] //CREATE
        public void Post([FromBody] Customers customers)
        {
  
        }

        // PUT: api/Songs/5
        [HttpPut("{id}")] //UPDATE
        public void Put(int id, [FromBody] Songs song)
        {

        }

        // DELETE: api/Songs/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            System.Console.WriteLine(id);
        }
    }
}