using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        #region skrammel
        [HttpGet("Kaffe")]
        public string getSeb()
        {
            return "Sebastian";
        }

        [HttpGet("all")]
        public List<Car> getCars()
        {
            // We want to query all cars from database
            string sql = "select * from cars";
            return context.Car.ToList();
            // 1) collection  - context.TableName
            // 2) LINQ method, that query the wanted result from
            //    Database.
            //    ex: context.Car.Max(); // get max "id" from
            //    a table....
            // 3) The LINQ statement has to be invoked
            //    Use ToList(), ToArray() or foreach to invoke the
            //    LINQ query..


        }
        // // We want to query all cars where brand is volvo

        [HttpPost]
        void postCars()
        {
            //var tt = context.Car.Where()
        }

        //opgave 1-3 efter POST
        // 0) POST opgave.. opret en car med foreign key i tabellen
        // 1)hardcode 1 method, som finder alle brands == "Volvo"
        // 2)hardcode 1 method, som finder alle brands == "BMW"
        // 3)1 method, som kan finde alle slags brands
        #endregion skrammel
        [HttpGet("eks1")]
        public async Task<ActionResult<Car>> eks1()
        {
            return await context.Car.Where((Car c) => true)
                .FirstOrDefaultAsync();
           
        }
        [HttpGet("eks2")]
        public async Task<ActionResult<Car>> eks2()
        {
            return await context.Car.Where((Car c) => c.Brand=="BMW")
                .FirstOrDefaultAsync();
            // null ? res: new Car()
        }
        [HttpGet("eks3")]
        public async Task<ActionResult<Car>> eks3()
        {
            return await context.Car.Where((Car c) => c.Brand == "BMW" && c.Id == 1)
                .FirstOrDefaultAsync();
        }

        [HttpGet("eks22")]
        public async Task<ActionResult<Car>> eks22()
        {
            var tt= await context.Car.Where(c => c.Brand == "BMW")
                .FirstOrDefaultAsync();
            return tt;
            // null ? res: new Car()
        }

        [HttpGet("EnTilMange")]
        public async Task<ActionResult<List<Person>>> eks23()
        {
            // join 2 tables (Join, include, query syntax
            // og 1 til)
            var tt = await context.Person.Include((obj) => obj.cars)
                .ToListAsync();
            return tt;
        }

        [HttpGet("EnTilMangePerson")]
        public async Task<ActionResult<List<Person>>> eks24()
        {
            var tt = await context.Person.Include((obj) => obj.cars)
               .Where(person=>person.id==1).ToListAsync();
            //return tt;
            return null;
        }

        //[HttpPost("test22")]
        //public async Task<ActionResult<List<Car>>> eks25()
        //{
        //    string sql = "her er der noget hardcode data";
        //    Car myCar = new Car();
        //    myCar.Brand = "Cacao";
        //    return null;
        //}
    }
}
