// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");


//    
    using DataFunction;
   
    

    //  Burger Burger1 = new Burger();
    //   Console.WriteLine(Burger());
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
               string toppings = Console.ReadLine();
            Console.WriteLine($" {toppings} was added to your list!");
            Console.WriteLine("[1] done");
            Console.WriteLine("[2] add toppings");
            string userChoice = Console.ReadLine();
            if(userInput == "1"){

                 Console.WriteLine("You meal is being prepared");
                 


            }
            else if (userInput == "2"){
               
            

            }
            

            
          

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
            
         Data data1 = new Data()
         {
             Meat="Medium-Rare",
             Bun="Seaseme",
             Cost=5
         };  
          Console.WriteLine($"Your burger meat is {data1.Meat}");
          Console.WriteLine($"Your bun type is {data1.Bun}");
        Console.WriteLine($"Your burger Cost is {data1.Cost} dollars");






        
        }

        if(userInput == "2")
        {
            Console.WriteLine("Have a nice day!");
        }
}

    