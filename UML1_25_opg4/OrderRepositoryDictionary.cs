using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace UML1_25_opg4
{
    public class OrderRepositoryDictionary
    {
        private Dictionary<int, Order> _orders;
        public int Count { get { return _orders.Count; } }
        private static int _orderCounter;

        public OrderRepositoryDictionary()
        {
            _orderCounter = 0;
            _orders = new Dictionary<int, Order>();
            
        }
        public void AddOrder(Order order)
        {
            ++_orderCounter;
            _orders.Add(_orderCounter, order);
        }

        public Order? SearchOrder(int orderNumber)
        {
            if (_orders.ContainsKey(orderNumber)) { return _orders[orderNumber]; }
            return null;
        }

        public void DeleteOrder(int orderNumber)
        {
            _orders.Remove(orderNumber);
        }

        public void UpdateOrder(int orderNumber, Order updatedOrder)
        {
            _orders.Remove(orderNumber);
            _orders.Add(orderNumber, updatedOrder);
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
