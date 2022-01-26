namespace ProjUI
{

    public class MainMenu
    {
         public void Display()
        {
            Console.WriteLine("Welcome to Revature Ice Cream!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("[1] Order Ice Cream");
            Console.WriteLine("[0] Exit");
        }
    

    public string UserChoice()
    {
        string userInput = Console.ReadLine();

        switch (userInput)
            {
                case "0":
                    return "Exit";
                case "1":
                    return "AddIceCream";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "MainMenu";
            }


    }


    }



}