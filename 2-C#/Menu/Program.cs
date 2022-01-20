// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");


//    
    using DataFunction;
    using System.Collections;

   

    bool repeat = true;
    Data data1 = new Data()
         {
             Meat="Medium-Rare",
             Bun="Seaseme",
             Cost=5
         };  
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
            Console.WriteLine("[1] done");
            Console.WriteLine("[2] add toppings");
            string userChoice = Console.ReadLine();
            if(userChoice == "1")
            {

                 Console.WriteLine("You meal is being prepared");
                 data1.AddToppingList(toppings);
                 data1.ShowToppingList(toppings);
            }
        else if (userChoice == "2")
            {
                
                Console.WriteLine("what would you like for your second topping?");
                string toppings2 = Console.ReadLine();
                data1.AddToppingList(toppings2);
                data1.ShowToppingList(toppings2);
            

            }
        
            
            

            
          
        }
        else if(userInput=="2")
        {
            
            Console.WriteLine("You meal is being prepared");

        }
        
            
         
        //   Console.WriteLine($"Your burger meat is {data1.Meat}");
        //   Console.WriteLine($"Your bun type is {data1.Bun}");
        // Console.WriteLine($"Your burger Cost is {data1.Cost} dollars");
        
        

        
}

    