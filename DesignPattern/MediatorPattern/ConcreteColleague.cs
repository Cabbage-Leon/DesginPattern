using System;

namespace DesignPattern.MediatorPattern
{
    public class ConcreteColleague : Colleague
    {
        public ConcreteColleague(int id)
        {
            Id = id;
        }

        public override void Receive(int from, string message)
        {
            Console.WriteLine($"{from}说：" + message);
        }

        public override void Send(string message)
        {
            this.Mediator.Relay(this,message);
        }
    }
}
