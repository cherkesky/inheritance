using System;
using System.Collections.Generic;


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



    //AGGREGATION
class Customer
{
    public string AccountNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Bank
{
    public string Name { get; set; }
    public string Address { get; set; }

    // Customers are aggregated into the bank
    public List<Customer> Customers { get; set; } = new List<Customer>();

}




    static void Main(string[] args)
    {
        Bank FirstTennessee = new Bank() {
            Name = "First Tennessee",
            Address = "100 Infinity Way"
        };

        // Create a customer
        Customer steve = new Customer();
        steve.FirstName = "Steve";
        steve.LastName = "Brownlee";
        steve.AccountNumber = "110405821101";

        // Add Steve to First Tennessee's list of customers
        FirstTennessee.Customers.Add(steve);

        // Add another customer using in-line, concise syntax
        FirstTennessee.Customers.Add(
            new Customer() {
            FirstName = "Caitlin",
            LastName = "Stein",
            AccountNumber = "0592382394589" }
        );

        // Iterate over the list of customers and display the first name
        foreach (Customer cust in FirstTennessee.Customers)
        {
            Console.WriteLine(cust.FirstName);
        }    }
  }
}
