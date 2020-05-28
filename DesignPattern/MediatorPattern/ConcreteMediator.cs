using System.Collections.Generic;

namespace DesignPattern.MediatorPattern
{
    public class ConcreteMediator : Mediator
    {
        public IList<Colleague> Colleagues { get; set; } = new List<Colleague>();

        public override void Register(Colleague colleague)
        {
            if (!Colleagues.Contains(colleague))
            {
                Colleagues.Add(colleague);
                colleague.Mediator = this;
            }
        }

        public override void Relay(Colleague cl, string message)
        {
            foreach (var colleague in Colleagues)
            {
                if (colleague.Id != cl.Id)
                {
                    colleague.Receive(cl.Id, message);
                }
            }
        }
    }
}
