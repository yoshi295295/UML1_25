using System;
using System.Collections.Generic;
using System.Text;

namespace UML1_25
{
    public class Order
    {
        private static int _orderID = 0;
        public int OrderID { get; private set; }
        private Pizza _pizzaOrdered;
        private Customer _orderCustomer;
        public double? TotalPrice { get; private set; }

        public Order(Customer customer, Pizza pizza)
        {
            _orderCustomer = customer;
            _orderID++;
            OrderID = _orderID;
            _pizzaOrdered = pizza;
            TotalPrice += (pizza.Price + 40) * 1.25;
        }
        public override string ToString()
        {
            return $"Order no: {OrderID}; Pizza ordered: {_pizzaOrdered.ToString()}\nCustomer: {_orderCustomer.ToString()}\nTotal Price: {TotalPrice}\n";
        }
    }
}
