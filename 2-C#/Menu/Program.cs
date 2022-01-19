// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

    Console.Clear();
    bool repeat = true;
  while (repeat)
  {
        Console.WriteLine("Welcome to the Krusty Krab!");
        Console.WriteLine("PLease tell me your name");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello {name}, what would you like to order?");
        Console.WriteLine("[1] - Krabby Patty");
        Console.WriteLine("[2] - Exit");

        string userInput = Console.ReadLine();

        if(userInput == "1")
        {
            Console.WriteLine("Please choose your toppings");
            Console.WriteLine("[1] - Ketchup");
            Console.WriteLine("[2] - Mustard");
            Console.WriteLine("[3] - Ketchup & Mustard");
            

            
            string toppings = Console.ReadLine();
            

        if(toppings == "1")
        {
            Console.WriteLine("Enjoy your Krabby Patty with Ketchup!");

        }
        else if(toppings == "2")
        {
            Console.WriteLine("Enjoy your Krabby Patty with Mustard!");
        }
        else if(toppings == "3")
        {
            Console.WriteLine("Enjoy your Krabby Patty with Ketchup and Mustard!");
        }
            
            
        
        }

        if(userInput == "2")
        {
            Console.WriteLine("Have a nice day");
        }
}

    