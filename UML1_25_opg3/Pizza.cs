using System;
using System.Collections.Generic;
using System.Text;

namespace UML1_25_opg3
{
    public class Pizza
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Toppings { get; set; }
        public double Price { get; set; }
        public string? Comment { get; set; }
        public List<Topping?> _extraToppings;

        public Pizza(int number, string name, string toppings, double price)
        {
            _extraToppings = new List<Topping?>();
            Number = number;
            Name = name;
            Toppings = toppings;
            Price = price;
            Comment = null;
        }

        public void AddExtraTopping(Topping topping)
        {
            _extraToppings.Add(topping);
        }


        public string ListExtraToppings()
        {
            string extraToppings = "";
            foreach (var topping in _extraToppings)
            {
                extraToppings = extraToppings + "\n" + topping.ToString();
            }
            return extraToppings;
        }

        public override string ToString()
        {
            return $"No: {Number}; Name: {Name}; Toppings: {Toppings}, Price: {Price}\nComment: {Comment}\nExtra toppings: {ListExtraToppings()}";
        }
    }
}
