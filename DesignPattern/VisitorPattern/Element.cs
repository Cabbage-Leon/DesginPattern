using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.VisitorPattern
{
    public interface Element
    {
        void Accept(Visitor visitor);
    }
}
