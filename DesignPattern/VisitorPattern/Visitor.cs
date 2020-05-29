using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.VisitorPattern
{
    public interface Visitor
    {
        void Visit(ConcreteElement element);
        void Visit(ConcreteElementB elementB);
    }
}
