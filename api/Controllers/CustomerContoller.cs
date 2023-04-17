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
    public class CustomerController : ControllerBase
    {
        public List<Customers> AllCustomers = new List<Customers>();
        // GET: api/Course
        [HttpGet]
        public List<Customers> Get()
        {
            ReadCustomer ReadObject = new ReadCustomer();
            AllCustomers = ReadObject.GetCustomers();
            return AllCustomers;
        }

        // GET: api/Customers/5
        [HttpGet("{id}", Name = "Customer")]
        public string GetOne(int id)
        {
            return "value";
        }


        // POST: api/customers
        [HttpPost] //CREATE
        public void Post([FromBody] Customers customers)
        {

        }

        // PUT: api/Customers/5
        [HttpPut("{id}")] //UPDATE
        public void Put(int id, [FromBody] Customers customers)
        {

        }

        // DELETE: api/Customers/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            System.Console.WriteLine(id);
        }
    }
}