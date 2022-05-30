using Decorator.Components;
//The Using directive allowing you to use data from other files
namespace Decorator.Components
//creating a public class called program for ogranisation
{
    public class Members : TicketType
    //Creating a new public class frenchcrepes that inherits to pancakes
    {
        public Members()
        //Constructor crating Frenchcrepes
        {
            Description = "Member";
            //adding a string to the description attribute
        }

        public override double Cost()
        //creatting the method Cost that is set to public double and the overide to modify the abstraction
        {
            return 0;
            //returning the value 6.5 for the Cost method
        }
    }
}


