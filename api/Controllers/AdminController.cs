using Microsoft.AspNetCore.Mvc;
using api.Models;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        public List<Cars> AllCars = new List<Cars>();
        // GET: api/Course
        [HttpGet]
        public List<Cars> Get()
        {
            return 
        }

        // GET: api/Cars/5
        [HttpGet("{id}", Name = "Get")]
     

        // POST: api/Cars
        [HttpPost] //CREATE
        public void Post([FromBody] Cars cars)
        {
  
        }

        // PUT: api/Cars/5
        [HttpPut("{id}")] //UPDATE
        public void Put(int id, [FromBody] Car cars)
        {

        }

        // DELETE: api/Cars/5
        [HttpDelete("{id}")]
        public void Delete
        {
           
        }
    }
}