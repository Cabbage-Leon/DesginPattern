using System.Collections.Generic;

namespace DesignPattern.VisitorPattern
{
    //维护一个集合，集体接受访问者的访问。
    //访问者会一个一个拜访
    public class Structure
    {
        public IList<Element> Elements = new List<Element>();

        public void Accept(Visitor visitor)
        {
            foreach (var element in Elements)
            {
                element.Accept(visitor);
            }
        }

        public void Add(Element element)
        {
            Elements.Add(element);
        }
        public void Remove(Element element)
        {
            Elements.Remove(element);
        }
    }
}
