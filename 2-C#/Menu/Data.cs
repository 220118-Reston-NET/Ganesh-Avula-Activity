using System.Collections;
namespace DataFunction
{


    public class Data
    {

        


        private string _meat;
        private string _bun;

        private int _cost;
        private List<string> _toppingsList = new List<string>();
    
        
        public string Meat
        {
             get { return _meat; }
            set { _meat = value; }
        }
        public string Bun
        {
             get { return _bun; }
            set { _bun = value; }
        }
        public int Cost { get; set; }

        public Data()
        {
            _meat = "Rare";
            _bun = "Seaseme";
            _cost = 10;

        }

         public void SearchToppingList(string toppings)
        {
         
            foreach (string item in _toppingsList)
            {
                if(toppings == item)
                {
                    _toppingsList.Add(toppings);
                    Console.WriteLine($"{toppings} has been added to the list!");
                }
            }
        
        
        }

        public void ShowToppingList(string toppings)
        {
                   foreach (string item in _toppingsList)
            {
                if(toppings == item)
                {
                    
                    Console.WriteLine($"your toppings are: {toppings} ");
                }
            }
        }
        public void AddToppingList(string toppings)
        {
                     _toppingsList.Add(toppings);
                    
                    
                    
        }



    }
}

