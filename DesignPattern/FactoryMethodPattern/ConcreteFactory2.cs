using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryMethodPattern
{
    class ConcreteFactory2 : AbstractFactory
    {
        public ConcreteFactory2()
        {
            Console.WriteLine("创建工厂2");
        }
        public IProduct CreateProduct()
        {
            Console.WriteLine("创建产品2");
            return new ConcreteProduct2();
        }
    }
}
