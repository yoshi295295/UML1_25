using System;
using System.Collections.Generic;
using System.Text;

namespace UML1_25_opg4
{
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        private static int _customerID;
        public int CustomerID { get; private set; }

        public Customer(string name, string address)
        {
            CustomerID = ++_customerID;
            Name = name;
            Address = address;
        }

        public override string ToString()
        {
            return $"ID: {CustomerID}; Name: {Name}; Address: {Address}";
        }
    }
}
