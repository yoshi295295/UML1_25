using UML1_25_opg4;

Customer cust1 = new("Tom Jensen", "Havevej 3");
Customer cust2 = new("Lars Jensen", "Blomstvej 5");
Customer cust3 = new("Niels Jensen", "Gårdvej 7");
Customer cust4 = new("Daniel Jensen", "Møllevej 9");

Pizza margherita = new(1, "Margherita", "Tomato Sauce, Cheese", 59.95);
Pizza vesuvio = new(2, "Vesuvio", "Tomato Sauce, Cheese, Ham", 69.95);
Pizza hawaii = new(3, "Hawaii", "Tomato Sauce, Cheese, Pineapple", 64.95);

Topping champignon = new("Champignon", 5);
Topping chili = new("Chili", 7);

Order order1 = new(cust1, margherita);

Order order2 = new(cust2, vesuvio);
order2.AddPizza(margherita, "Extra chili");
order2.UpdatePizza(chili);
order2.AddPizza(margherita);

Order order3 = new(cust3, hawaii, "Extra champignon");
order3.UpdatePizza(champignon);
order3.AddPizza(hawaii, "Extra champignon and chili please");
order3.UpdatePizza(champignon);
order3.UpdatePizza(chili);

Order order4 = new(cust4, vesuvio, "Noget extra chili, mange tak");
order4.UpdatePizza(chili);

//OrderRepositoryList orderRepo = new();
OrderRepositoryDictionary orderRepo = new();
orderRepo.AddOrder(order1);
orderRepo.AddOrder(order2);
orderRepo.AddOrder(order3);

Order? foundOrder = orderRepo.SearchOrder(1);
if (foundOrder != null)
{
    Console.WriteLine(foundOrder);
}
else { Console.WriteLine("Order not found"); }

orderRepo.UpdateOrder(3, order4);

orderRepo.PrintAll();

//Console.WriteLine(order1.ToString());
//Console.WriteLine(order2.ToString());
//Console.WriteLine(order3.ToString());