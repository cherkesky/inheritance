using System;

namespace inheritance
{
  class Program
  {
    /*
This parent class will contain properties that
are common across all of the specific kinds of
balls in our program.
*/
    class Ball
    {
      public double radius { get; set; }
      public double weight { get; set; }
    }

    /*
        By putting `: Ball` after the definition of
        Baseball, any object created from this class
        would automatically have the two properties of
        radius and weight.
    */
    class Baseball : Ball
    {
      // Stitches is not common to every kind of ball
      public int stitches { get; set; }
    }

    // All soccer balls will also have radius and weight
    class SoccerBall : Ball
    {
      // Panels is not common to every kind of ball
      public int panels { get; set; }
    }


    

 // COMPOSITION
class Pancreas
{
    public bool filtering { get; set; }
}

class Liver
{
    public bool poisoned { get; set; }
}
class Body
{
    /*
        Making these private. Don't want anyone
        messing around with my liver and pancreas
    */
    private Pancreas _pancreas;
    private Liver _liver;

    public Body ()
    {
        // Create a brand new pancreas and assign it to this body
        _pancreas = new Pancreas(){
            filtering = true
        };

        // Create a brand new liver and assign it to this body
        _liver = new Liver(){
            poisoned = false
        };
    }
}










    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }
}
