// See https://aka.ms/new-console-template for more information
using ProjUI;
using ProjModel;


//Console.WriteLine("Hello, World!");

//bool repeat=true;


//while(repeat)
//{
    
    
    IMenu menu = new MainMenu();
    IceCream order1 = new IceCream();
    
    menu.Display();

    string ans = menu.UserInput();

    
    
//}



