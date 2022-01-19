//namespace is a great way to organize your code

namespace CarFunction
{
    //this is how you create a class by using the class keyword
    //public is just to make the class visible for everyon else
    

public class Car 
{

    //Field
    //It is used to store info or define current state of the object when you first make it
    // private means that only the classs itself can use that field
    private string _color;
    private string _owner;
    private int _fuel;
    private int _gallonPerMile;

    //property
    //they are in pascalcase

    public string Color
        {
        get return _color;
         }


    }


}