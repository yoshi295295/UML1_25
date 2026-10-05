using System;
using System.Collections.Generic;
using System.Text;

namespace UML1_25_opg3
{
    public class OrderLine
    {
        private Dictionary<int, Pizza> _pizzaList;
        public Dictionary<int, Pizza> PizzaList { get { return _pizzaList; } }
        private Pizza? _pizzaStore;
        private static int _pizzaNo;
        public int PizzaNo { get { return _pizzaNo; } }

        public OrderLine() {
            _pizzaNo = 0;
            _pizzaList = new Dictionary<int, Pizza>();
        }

        public void AddCommentLine(int pizza, string comment)
        {
            _pizzaList[pizza].Comment = comment;
        }

        public void AddPizzaLine(Pizza pizza)
        {
            ++_pizzaNo;
            _pizzaStore = new Pizza(pizza.Number, pizza.Name, pizza.Toppings, pizza.Price);
            _pizzaList.Add(_pizzaNo, _pizzaStore);
        }


        public void UpdatePizzaLine(int pizza, Topping topping)
        {
            _pizzaList[pizza].AddExtraTopping(topping);
        } 
    }
}
