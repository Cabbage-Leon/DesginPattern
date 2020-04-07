using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactoryPattern
{
    public class ConcreteProduct2 : IProduct2
    {
        public void Show()
        {
            Console.WriteLine("Show1");
        }
    }
}
