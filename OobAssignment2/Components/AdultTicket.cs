using Decorator.Components;
//The Using directive allowing you to use data from other files
namespace Decorator.Components
//creating a public class called program for ogranisation
{
    public class Adult : TicketType
    //Creating a new public class Adult that inherits to Tickettype
    {
        public Adult()
        //Constructor making Adult
        {
            Description = "Adult";
            //setting the Description field with Adult string
        }

        public override double Cost()
        //creatting the method Cost that is set to public double and the overide to modify the abstraction
        {
            return 25;
            //returning the value 6.5 for the Cost method
        }
    }
}


