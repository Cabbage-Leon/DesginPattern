namespace DesignPattern.MediatorPattern
{
    public abstract class Mediator
    {
        public abstract void Register(Colleague colleague);
        public abstract void Relay(Colleague colleague,string message); 
    }
}
