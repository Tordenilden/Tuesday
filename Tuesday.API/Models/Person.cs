﻿namespace Tuesday.API.Models
{
    // Person is a type!!
    public class Person // its called a Model
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public List<Car> cars { get; set; }//foreign key til car
        public Person()
        {
            cars = new List<Car>();
        }
    }
}
