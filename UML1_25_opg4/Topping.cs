using System;
using System.Collections.Generic;
using System.Text;

namespace UML1_25_opg4
{
    public class Topping
    {
        public string Name { get; private set; }
        public double Price { get; private set; }
        
        public Topping(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"Name: {Name}; Price: {Price} kr.";
        }
    }
}
