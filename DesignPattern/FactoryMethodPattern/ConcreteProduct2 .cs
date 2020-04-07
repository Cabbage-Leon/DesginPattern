using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryMethodPattern
{
    public class ConcreteProduct2 : IProduct
    {
        public void Show()
        {
            Console.WriteLine("Show1");
        }
    }
}
