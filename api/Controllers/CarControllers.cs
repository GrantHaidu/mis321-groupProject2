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


namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        public List<Cars> AllCars = new List<Cars>();
        // GET: api/Course
        [HttpGet]
        public List<Cars> Get()
        {

            ReadCar ReadObject = new ReadCar();
            AllCars = ReadObject.GetCars();
            return AllCars;
        }

        // GET: api/Cars/5
        [HttpGet("{id}", Name = "Cars")]
        public string GetOne(int id)
        {
            return "value";
        }

        // POST: api/Cars
        [HttpPost] //CREATE
        public void Post([FromBody] Cars cars)
        {

        }

        // PUT: api/Cars/5
        [HttpPut("{id}")] //UPDATE
        public void Put(int id, [FromBody] Cars cars)
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