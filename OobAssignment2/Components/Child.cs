using Decorator.Components;
//The Using directive allowing you to use data from other files
namespace Decorator.Components
//creating a public class called program for ogranisation
{
    public class Child : TicketType
    //Creating a new public class Dropscones that inherits to pancakes
    {
        public Child()
        //Constructor making Dropscone
        {
            Description = "Child";
            //setting the Description field with Dropscone string
        }

        public override double Cost()
        //creatting the method Cost that is set to public double and the overide to modify the abstraction
        {
            return 5.50;
            //returning the value 6.5 for the Cost method
        }
    }
}


