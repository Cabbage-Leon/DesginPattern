using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactoryPattern
{
    class ConcreteFactory12 : AbstractFactory1
    {
        public ConcreteFactory12()
        {
            Console.WriteLine("创建工厂2");
        }

        public IProduct1 CreateProduct1()
        {
            Console.WriteLine("创建产品组1");
            return new ConcreteProduct1();
        }

        public IProduct2 CreateProduct2()
        {
            Console.WriteLine("创建产品组2");
            return new ConcreteProduct2();
        }
    }
}
