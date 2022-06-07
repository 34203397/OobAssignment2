using Decorator.Components;
using Decorator.Decorators;
//The Using directive allowing you to use data from other files
namespace Decorator.Decorators
//creating a public class called program for ogranisation
{
    public class Tour : ExtraCharges
    //Creating a new public class Lemon that inherits to ExtraCharges
    {
        private readonly TicketType _extra;
        //creating a field thats private and readonly so it cannot be seen outside of the method and cannot be changed

        public Tour(TicketType Extra)
        // A constructor using the arguments Tickettype in the parameter Extra
        {
            _extra = Extra;
            //Setting the _extra field equaul to the variable Extra
        }

        public override double Cost()
        //creatting the method Cost that is set to public double and the overide to modify the abstraction
        {
            return 25.50 + _extra.Cost();
            //returning the value 6.5 for the Cost method
        }

        public override string Description => _extra.Description + ", Guided Tour";
        //Creating the field description with the addition of the string Tour using the lambda
    }
}


