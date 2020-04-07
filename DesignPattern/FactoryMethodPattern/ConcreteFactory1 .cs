using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryMethodPattern
{
    class ConcreteFactory1 : AbstractFactory
    {
        public ConcreteFactory1()
        {
            Console.WriteLine("创建工厂1");
        }
        public IProduct CreateProduct()
        {
            Console.WriteLine("创建产品1");
            return new ConcreteProduct1();
        }
    }
}
