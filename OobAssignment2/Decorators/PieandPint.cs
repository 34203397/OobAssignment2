using Decorator.Components;
using Decorator.Decorators;
//The Using directive allowing you to use data from other filess
namespace Decorator.Decorators
//creating a public class called program for ogranisation
{
    public class PieandPint : ExtraCharges
    //Creating a new public class PieandPint that inherits to ExtraCharges
    {
        private readonly TicketType _extra;
        //creating a field thats private and readonly so it cannot be seen outside of the method and cannot be changed

        public PieandPint(TicketType Extra)
        // A constructor using the arguments TicketType in the parameter Extra
        {
            _extra = Extra;
            //Setting the _extra field equaul to the variable Extra
        }

        public override string Description => _extra.Description + ", Pie and Pint (Kids version included)";
        //Creating the field description with the addition of the string Pie and Pint using the lambda

        public override double Cost()
        //creatting the method Cost that is set to public double and the overide to modify the abstraction
        {
            return 4.5 + _extra.Cost();
            //returning the value 6.5 for the Cost method
        }
    }
}


