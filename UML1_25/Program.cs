using UML1_25;
Customer cust1 = new("Tom Jensen", "Havevej 3");
Customer cust2 = new("Lars Jensen", "Blomstvej 5");
Customer cust3 = new("Niels Jensen", "Gårdvej 7");

Pizza margherita = new(1, "Margherita", "Tomato Sauce, Cheese", 59.95);
Pizza vesuvio = new(2, "Vesuvio", "Tomato Sauce, Cheese, Ham", 69.95);
Pizza hawaii = new(3, "Hawaii", "Tomato Sauce, Cheese, Pineapple", 64.95);

Console.WriteLine(margherita.ToString());
Console.WriteLine(vesuvio.ToString());
Console.WriteLine(hawaii.ToString());

Console.WriteLine(cust1.ToString());
Console.WriteLine(cust2.ToString());
Console.WriteLine(cust3.ToString());

Order order1 = new(cust1, margherita);
//order1.AddPizza(vesuvio);
Order order2 = new(cust2, vesuvio);
Order order3 = new(cust3, hawaii);

Console.WriteLine(order1.ToString());
Console.WriteLine(order2.ToString());
Console.WriteLine(order3.ToString());