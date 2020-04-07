using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactoryPattern
{
    class ConcreteProduct1 : IProduct1
    {
        public void Show()
        {
            Console.WriteLine("show2");
        }
    }
}
