using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using api.Models;
using api.CRUDFunctions;
using api.Database;
using api.Interfaces;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        public List<Cars> AllSongs = new List<Cars>();
        // GET: api/Course
        [HttpGet]
        public List<Cars> Get()
        {

        }

        // GET: api/Cars/5
        [HttpGet("{id}", Name = "Get")]
     

        // POST: api/Cars
        [HttpPost] //CREATE
        public void Post([FromBody] Car cars)
        {
  
        }

        // PUT: api/Cars/5
        [HttpPut("{id}")] //UPDATE
        public void Put(int id, [FromBody] Car cars)
        {

        }

        // DELETE: api/Cars/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            System.Console.WriteLine(id);
        }
    }
}