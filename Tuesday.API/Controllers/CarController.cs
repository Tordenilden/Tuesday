using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tuesday.API.Data;
using Tuesday.API.Models;

namespace Tuesday.API.Controllers
{
    //https://localhost:7199/api/car/kaffe
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly DatabaseContext context;
        public CarController(DatabaseContext context)
        {
            this.context = context;
        }
        [HttpGet("Kaffe")]
        public string getSeb()
        {
            return "Sebastian";
        }

        [HttpGet("all")]
        public List<Car> getCars()
        {
            // We want to query all cars from database
            return null;
        }
        // // We want to query all cars where brand is volvo

    }
}
