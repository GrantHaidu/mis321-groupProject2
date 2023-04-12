using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using api.Models;
using api.Database;
using api.CRUDFunctions;


namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        public List<Admin> AllAdmins = new List<Admin>();
        // GET: api/Course
        [HttpGet]
        public List<Admin> Get()
        {
            ReadAdmin ReadObject = new ReadAdmin();
            AllAdmins = ReadObject.GetAdmins();
            return AllAdmins;
        }

        // GET: api/Admins/5
        [HttpGet("{id}", Name = "Admin")]
        public string GetOne(int id)
        {
            return "value";
        }


        // POST: api/Admins
        [HttpPost] //CREATE
        public void Post([FromBody] Admin admins)
        {

        }

        // PUT: api/Admin/5
        [HttpPut("{id}")] //UPDATE
        public void Put(int id, [FromBody] Admin Admins)
        {

        }

        // DELETE: api/Admins/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            System.Console.WriteLine(id);
        }
    }
}