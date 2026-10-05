using System;
using System.Collections.Generic;
using System.Text;

namespace UML1_25_opg4
{
    public class Order
    {
        private OrderLine _orderLine;
        private static int _orderID = 0;
        public int OrderID { get; private set; }
        private Customer _orderCustomer;
        public double? TotalPrice { get; private set; }
        public int NoOfItems { get { return _orderLine.PizzaList.Count; } }

        public Order(Customer customer, Pizza pizza, string? comment = null)
        {
            _orderLine = new OrderLine();
            _orderCustomer = customer;
            OrderID = ++_orderID;
            AddPizza(pizza, comment);
        }

        public void AddComment(int pizza, string comment)
        {
            if (comment != null)
            {
                _orderLine.AddCommentLine(pizza, comment);
            }
        }

        public void AddPizza(Pizza pizza, string? comment = null)
        {
            _orderLine.AddPizzaLine(pizza);
            AddComment(_orderLine.PizzaNo, comment);
            CalculateTotalPrice();
        }

        public void UpdatePizza(int pizza, Topping extraTopping)
        {
            _orderLine.UpdatePizzaLine(pizza, extraTopping);
            CalculateTotalPrice();
        }

        public double? CalculateTotalPrice()
        {
            double? sum = 0;
            foreach (var pizza in _orderLine.PizzaList)
            {
                sum += pizza.Value.Price;
                if (pizza.Value._extraToppings != null)
                {
                    foreach (var extraTopping in pizza.Value._extraToppings)
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
            foreach (var pizza in _orderLine.PizzaList)
            {
                allPizzas = allPizzas + "\n" + pizza.ToString();
            }
            return allPizzas;
        }

        public override string ToString()
        {
            return $"Order ID: {OrderID}\n{NoOfItems} pizza(s) ordered: {ListAllPizzas()}\nCustomer: {_orderCustomer.ToString()}\nTotal Price: {CalculateTotalPrice()}\n";
        }
    }
}
