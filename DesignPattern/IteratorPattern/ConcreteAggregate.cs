using System.Collections.Generic;

namespace DesignPattern.IteratorPattern
{
    /// <summary>
    /// 具体聚合对象
    /// </summary>
    /// <typeparam name="TClass"></typeparam>
    public class ConcreteAggregate<TClass> : IAggregate<TClass>
    {
        private readonly IList<TClass> List  = new List<TClass>();

        public void Add(TClass obj)
        {
            List.Add(obj);
        }

        public void Remove(TClass obj)
        {
            List.Remove(obj);
        }

        public ITerator<TClass> GetIterator()
        {
            return new Concretelterator<TClass>(List);
        }

    }
}
