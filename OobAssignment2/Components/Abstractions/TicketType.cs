namespace Decorator.Components
//creating a public class called program for ogranisation
{
    public abstract class TicketType
    //Creating a new class set as public so other classes can access it and abstract so it will inherit from other classes
    {
        public virtual string Description { get; protected set; } = "Unknown Ticket";
        //string that will get the Desctription from other classes

        public abstract double Cost();
        //calls the Cost methot and sets it as public, abstracy and value as a double
    }
}

