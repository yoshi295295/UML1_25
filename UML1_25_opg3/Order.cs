using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace UML1_25_opg3
{
    public class Order
    {
        private List<Pizza> _pizzaList;
        private static int _orderID = 0;
        public int OrderID { get; private set; }
        private Customer _orderCustomer;
        public double? TotalPrice { get; private set; }
        public int NoOfItems { get { return _pizzaList.Count; } }
        public Topping ExtraTopping { get; private set; }
        public string Comment { get; private set; }

        public Order(Customer customer, Pizza pizza, string? comment = null)
        {
            _pizzaList = new List<Pizza>();
            _orderCustomer = customer;
            _orderID++;
            OrderID = _orderID;
            AddPizza(pizza);
            if (comment != null)
            {
                Comment = comment;
            }
            else Comment = null;
        }

        public void AddPizza(Pizza pizza)
        {
           _pizzaList.Add(pizza);
           CalculateTotalPrice();
        }

        public void UpdatePizza(Pizza pizza, Topping extraTopping)
        {
            if (_pizzaList.Contains(pizza))
            {
                pizza.AddExtraTopping(extraTopping);
                CalculateTotalPrice();
            }
        }

        public double? CalculateTotalPrice()
        {
            double? sum = 0;
            foreach (var pizza in _pizzaList)
            {
                sum += pizza.Price;
                if (pizza._extraToppings != null)
                {
                    foreach (var extraTopping in pizza._extraToppings)
                    {
                        sum += extraTopping.Price;
                    }
                }
            }
            if (sum != 0) 
            {
                TotalPrice = (sum + 40) * 1.25;
                return TotalPrice;
            }
            return null;
        }

        public string ListAllPizzas()
        {
            string allPizzas = "";
            foreach (var pizza in _pizzaList)
            {
                allPizzas = allPizzas + "\n" + pizza.ToString();
            }
            return allPizzas;
        }

        public override string ToString()
        {
            return $"{NoOfItems} pizza(s) ordered: {ListAllPizzas()}\nCustomer: {_orderCustomer.ToString()}\nComment: {Comment}\nTotal Price: {CalculateTotalPrice()}\n";
        }
    }
}
