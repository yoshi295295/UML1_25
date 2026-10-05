using System;
using System.Collections.Generic;
using System.Text;

namespace UML1_25_opg2
{
    public class Order
    {
        private List<Pizza> _pizzaList;
        private static int _orderID = 0;
        public int OrderID { get; private set; }
        private Customer _orderCustomer;
        public double? TotalPrice { get; private set; }
        public int NoOfItems { get { return _pizzaList.Count; } }

        public Order(Customer customer, Pizza pizza)
        {
            _pizzaList = new List<Pizza>();
            _orderCustomer = customer;
            _orderID++;
            OrderID = _orderID;
            AddPizza(pizza);
        }

        public void AddPizza(Pizza pizza)
        {
           _pizzaList.Add(pizza);
           CalculateTotalPrice();
        }

        public double? CalculateTotalPrice()
        {
            double? sum = 0;
            foreach(var pizza in _pizzaList)
            {
                sum += pizza.Price;
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
            return $"{NoOfItems} pizza(s) ordered: {ListAllPizzas()}\nCustomer: {_orderCustomer.ToString()}\nTotal Price: {CalculateTotalPrice()}\n";
        }
    }
}
