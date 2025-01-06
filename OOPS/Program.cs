using System.Runtime.CompilerServices;

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

