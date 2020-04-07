using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryMethodPattern
{
    class ConcreteProduct1 : IProduct
    {
        public void Show()
        {
            Console.WriteLine("show2");
        }
    }
}
