using System.Collections.Generic;

namespace DesignPattern.IteratorPattern
{
    public class Concretelterator<TClass> : ITerator<TClass>
    {
        private readonly IList<TClass> list = null;
        private int index = -1;


        public Concretelterator(IList<TClass> list)
        {
            this.list = list;
        }

        public bool HasNext()
        {
            if (index < list.Count - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public TClass First()
        {
            index = 0;
            TClass obj = list[index] ;
            return obj;
        }



        public TClass Next()
        {
            TClass obj = default;
            if (this.HasNext())
            {
                obj = list[++index];
            }
            return obj;
        }
    }
}
