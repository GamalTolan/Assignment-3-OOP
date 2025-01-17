using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_OOP
{
    internal class Car
    {
        public int Id { get; set; } 
        public string? Model { get; set; }
        public decimal Speed { get; set; }

        public Car(int id ,string? model, decimal speed)
        {
            Console.WriteLine("Constructor 01");
            Id = id;
           Model = model;
           Speed = speed;
        }

        public override string ToString()
        {
            return $"Id={Id}  Model = {Model}  Speed = {Speed} ";
        }

        public Car(int id, string? model) : this (id, model, 180) 
        {
            Console.WriteLine("Constructor 02");

        }
        public Car(int id): this(id,"Opel") 
        {
            Console.WriteLine("Constructor 03");
            //Id = id;    
        }
    }
}
