using Decorator.Components;
//The Using directive allowing you to use data from other files
namespace Decorator.Decorators
//creating a public class called program for ogranisation
{
    public abstract class ExtraCharges : TicketType
    //Creating a public class so that it is open to other files and methods and abstract meaning it cannot be changed also inheriting from TicketType
    {
        public abstract override string Description { get; }
        //creating a getter to retreive the string to go into Description from the different decorators and the overide to modify the abstraction
    }
}


