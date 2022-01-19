// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



    Console.Clear();
    Console.WriteLine("Welcome to Programming!");
    Console.WriteLine("PLease tell me your name");
    string name = Console.ReadLine();
    Console.WriteLine($"Hello {name}, what do you want to do today?");
    Console.WriteLine("[1] - Add two numbers");
    Console.WriteLine("[2] - Exit");

    string userInput = Console.ReadLine();

    if(userInput == "1")
    {
        Console.WriteLine("Please give me two numbers");
        
        
        int num1= Convert.ToInt32(Console.ReadLine());
        int num2= Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"The sum is: {num2+num1}");
    }