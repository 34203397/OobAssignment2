using Decorator.Components;
//The Using directive allowing you to use data from other files
namespace Decorator.Components
//creating a public class called program for ogranisation
{
    public class Adult : TicketType
    //Creating a new public class AmericanStyle that inherits to pancakes
    {
        public Adult()
        //Constructor making American style
        {
            Description = "Adult";
            //setting the Description field with Americanstyle string
        }

        public override double Cost()
        //creatting the method Cost that is set to public double and the overide to modify the abstraction
        {
            return 25;
            //returning the value 6.5 for the Cost method
        }
    }
}


