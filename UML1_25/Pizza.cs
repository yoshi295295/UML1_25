using System;
using System.Collections.Generic;
using System.Text;

namespace UML1_25
{
    public class Pizza
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Toppings { get; set; }
        public double Price { get; set; }

        public Pizza(int number, string name, string toppings, double price)
        {
            Number = number;
            Name = name;
            Toppings = toppings;
            Price = price;
        }

        public override string ToString()
        {
            return $"No: {Number}; Name: {Name}; Toppings: {Toppings}, Price: {Price}";
        }
    }
}
