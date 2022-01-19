// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

    Console.Clear();
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
        Console.WriteLine("[2] - Onions");
        Console.WriteLine("[2] - Tomatoes");
        Console.WriteLine("[2] - Lettuce");

        string toppings = Console.ReadLine();

        Console.WriteLine($"did you want {toppings}");
        
        
        int num1= Convert.ToInt32(Console.ReadLine());
        int num2= Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"The sum is: {num2+num1}");
    }