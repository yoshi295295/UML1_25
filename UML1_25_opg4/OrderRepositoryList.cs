using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization;
using System.Text;

namespace UML1_25_opg4
{
    public class OrderRepositoryList
    {
        private List<Order> _orders;
        public int Count { get { return _orders.Count; } }

        public OrderRepositoryList()
        {
            _orders = new List<Order>();
            
        }
        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }

        public Order? SearchOrder(int orderNumber)
        {
            foreach (var order in _orders)
            {
                if (order.OrderID == orderNumber) { return order; }
            }
            return null;
            }

        public void DeleteOrder(int orderNumber)
        {
            _orders.Remove(SearchOrder(orderNumber));
        }

        public void UpdateOrder(int orderNumber, Order updatedOrder)
        {
            DeleteOrder(orderNumber);
            _orders.Insert(orderNumber - 1, updatedOrder);
        }

        public void PrintAll()
        {
            foreach (var order in _orders)
            {
                Console.WriteLine(order.ToString());
            }
        }
    }
}
