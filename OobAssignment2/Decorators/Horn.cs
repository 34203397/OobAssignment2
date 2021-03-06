using Decorator.Components;
//The Using directive allowing you to use data from other files
namespace Decorator.Decorators
//creating a public class called program for ogranisation
{
    public class Horn : ExtraCharges
    //Creating a new public class Horn that inherits to ExtraCharges
    {
        private readonly TicketType _extra;
        //creating a field thats private and readonly so it cannot be seen outside of the method and cannot be changed

        public Horn(TicketType Extra)
        // A constructor using the arguments Ticketypw in the parameter Extra
        {
            _extra = Extra;
            //Setting the _extra field equaul to the variable Extra
        }

        public override double Cost()
        //creatting the method Cost that is set to public double and the overide to modify the abstraction
        {
            return 7.5 + _extra.Cost();
            //returning the value 6.5 for the Cost method
        }

        public override string Description => _extra.Description + ", Horn";
        //Creating the field description with the addition of the string Syrup using the lambda
    }
}


