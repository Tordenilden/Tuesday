using Microsoft.AspNetCore.Mvc;
using Tuesday.API.Models;

namespace Tuesday.API.Controllers
{
    [ApiController] // DataAnnotation eller Attribute
    [Route("[controller]")]
   // [Route("WeatherForecast")]// same as above
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}
        [HttpGet]// Attribute
        //public void hat()
        //{

        //}
        public string hat() { return "hej med dig"; }




        [HttpGet("Tuesday")]
        public string Tuesday() { return "this is tuesday"; }


        [HttpGet("Tuesday22/{name}")]
       // [Route("Tuesday22/{name:string}")]
        public void Tuesday22(string name) { string temp = name; }


        [HttpGet]
        [Route("Tuesday23/{name}")]
        public void Tuesday23(string name) { string temp = name; }

        [HttpGet("Tuesday24/{Id}")]
        //[Route("Tuesday24/{Id}")]
        public void Tuesday24(int Id) { int temp = Id; }

        //public Number1() { }
        //public Weekend() { }







        [HttpGet("person")]
        public Person person()
        {
            Person p = new Person
            {
                age = 5,
                name = "Bo",
                id = 1
            };
            return p;
        }
    }
}