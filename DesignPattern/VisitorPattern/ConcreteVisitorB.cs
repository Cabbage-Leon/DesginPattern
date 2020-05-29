using System;

namespace DesignPattern.VisitorPattern
{
    public class ConcreteVisitorB : Visitor
    {
        //主动去访问--指定具体的访问对象，有自己具体的访问行为
        public void Visit(ConcreteElement element)
        {
            Console.WriteLine(element.Operation() +"具体访问者B");
        }

        public void Visit(ConcreteElementB elementB)
        {
            Console.WriteLine(elementB.Operation() + "具体访问者B");
        }
    }
}
