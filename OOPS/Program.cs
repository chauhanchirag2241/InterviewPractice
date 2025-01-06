using System.Text;



namespace OOPS { 
public class program
{
    public static void Main(string[] args)
    {
      // can not create object of abstract class , static class and private class.
      
        Maths mats = new Maths();
        Social soc = new Social();
        Science scci = new Science();
    }
  
}

    private class Science
    {

    }
}
public abstract class Maths
{

}

public static class  Social
{
    
}

//Property is a class member that provides a flexible mechanism to read and write the value of a private filed.
public class MyClass
{
    private int myProperty;
    public int Myproperty
    {
        get { return myProperty; }
        set{ myProperty = value; }
    }
    public string MyProperty1 { get; set; }
}

//what is the difference between Property and Function?

//Property is a specialized function only
//Specialized means properties are used only to get and set field values.
public class Property_Function 
{
    public int MyProperty { get; set; }
    public int MyProperty()
    {
        //property is a function only so we can not create duplicate property and function in same class.
    }
}

//What are Namespaces?
// A namespace is a container for a set of related classes and other types.
//using System.Text;

namespace MyNamespace
{
    public class MyClass
    {
        StringBuilder StringBuilder = new StringBuilder();
    }
}
