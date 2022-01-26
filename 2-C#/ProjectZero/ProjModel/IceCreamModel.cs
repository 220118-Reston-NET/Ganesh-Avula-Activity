namespace ProjModel
{
    public class IceCream
    {
        public string Name {get; set;}
        public int   Scoops {get; set;}

        public string Flavor {get; set;}

        
        private List<Toppings> _toppings;
        public List<Toppings> Toppings
        {
            get { return _toppings; }

            set 
            { 
                if(_toppings.Count >0 && _toppings.Count <= 3)
                {
                    _toppings = value;
                }
                else
                {
                    throw new Exception("You can only choose up to 3 toppings");
                }
                 
            }
        }
        

       
       
        //Default constructor
        public IceCream()
        {
            Name = "Rocky Road";
            Scoops = 3;
            Flavor ="Chocolate";
          
        }

     
    }


    







}



