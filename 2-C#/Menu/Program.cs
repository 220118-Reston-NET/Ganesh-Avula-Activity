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
                         data1.AddToppingList(toppings);
                        data1.ShowToppingList(toppings);
                    }
                 else if (userChoice == "2")
                    {
                        Console.WriteLine("what would you like to add for your topping?");
                         data1.AddToppingList(toppings);
                        
                        string toppings2 = Console.ReadLine();
                        data1.AddToppingList(toppings2);
                        
                        
                    

                    }
            
            
          
        }

            
       
        
       
        else if(userInput=="2")
            {
            
                Console.WriteLine("cya!");

            }

        
        Console.WriteLine("[1] submit");
        Console.WriteLine("[2] change order");
        string FinalChoice = Console.ReadLine();
        if(FinalChoice == "1")
                    {
                     Console.WriteLine("Your order is preparing!");  
                    }
                 else if (FinalChoice == "2")
                    {
                       string toppings3 = Console.ReadLine();
                    data1.RemoveToppingList(toppings3);
                    data1.ShowToppingList(toppings3);

                    }

        
}

    