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
        public List<Songs> Get()
        {

        }

        // GET: api/Songs/5
        [HttpGet("{id}", Name = "Get")]
        public string GetOne(int id)
        {
        
        }

        // POST: api/Songs
        [HttpPost] //CREATE
        public void Post([FromBody] Songs song)
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