using DesignPattern.FactoryMethodPattern;
using System;

namespace DesignPattern.BuilderPattern
{
    public class ComplexHouse : IProduct
    {
        public string Door { get; set; }
        public string Floor { get; set; }
        public string Desk { get; set; }

        public void Show()
        {
            Console.WriteLine("构造好了");
        }
    }
}
