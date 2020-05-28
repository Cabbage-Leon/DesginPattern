namespace DesignPattern.MediatorPattern
{
    public abstract class Colleague
    {
        public int Id { get; set; }
        public Mediator Mediator { get; set; }
        public abstract void Receive(int from,string message);
        public abstract void Send(string message);
    }
}
