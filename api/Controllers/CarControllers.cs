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
        [HttpGet("{CarVIN}", Name = "Cars")]
        public string GetOne(int id)
        {
            return "value";
        }

        // POST: api/Cars
        [HttpPost("{CarVIN}")] //CREATE
        public void Post(int CarVIN, [FromBody] Cars car)
        {
            CreateCar newCar = new CreateCar();
            newCar.CreateOne(CarVIN, car);
        }


        // PUT: api/Cars/5
        [HttpPut("{CarVIN}")] //UPDATE
        public void Put(int CarVIN, [FromBody] Cars car)
        {
            //test
            System.Console.WriteLine("\nReceived request to update car...");

            UpdateCar updateCarBehavior = new UpdateCar();
            System.Console.WriteLine("About to update");
            System.Console.WriteLine(car.ToString());
            updateCarBehavior.Update(CarVIN, car);
        }

        // DELETE: api/Cars/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            System.Console.WriteLine(id);
        }
    }
}