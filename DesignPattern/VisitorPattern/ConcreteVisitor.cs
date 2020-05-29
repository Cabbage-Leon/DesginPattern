using System;

namespace DesignPattern.VisitorPattern
{
    //一个访问者对不同对象的访问
    public class ConcreteVisitor : Visitor
    {
        //主动去访问--指定具体的访问对象，有自己具体的访问行为
        public void Visit(ConcreteElement element)
        {
            Console.WriteLine(element.Operation() + "访问者A");
        }

        public void Visit(ConcreteElementB elementB)
        {
            Console.WriteLine(elementB.Operation() + "访问者A");
        }
    }
}
