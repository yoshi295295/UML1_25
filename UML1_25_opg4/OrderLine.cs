using System;
using System.Collections.Generic;
using System.Text;

namespace UML1_25_opg4
{
    public class OrderLine
    {
        private Dictionary<int, Pizza> _pizzaList;
        public Dictionary<int, Pizza> PizzaList { get { return _pizzaList; } }
        private Pizza? _pizzaStore;
        private static int _pizzaNo;

        public OrderLine() {
            _pizzaNo = 0;
            _pizzaList = new Dictionary<int, Pizza>();
        }

        public void AddCommentLine(string comment)
        {
            _pizzaList[_pizzaNo].Comment = comment;
        }

        public void AddPizzaLine(Pizza pizza)
        {
            ++_pizzaNo;
            _pizzaStore = new Pizza(pizza.Number, pizza.Name, pizza.Toppings, pizza.Price);
            _pizzaList.Add(_pizzaNo, _pizzaStore);
        }


        public void UpdatePizzaLine(Topping topping)
        {
            _pizzaList[_pizzaNo].AddExtraTopping(topping);
        } 
    }
}
