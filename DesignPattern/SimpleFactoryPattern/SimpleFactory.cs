using DesignPattern.BuilderPattern;
using DesignPattern.FactoryMethodPattern;

namespace DesignPattern.SimpleFactoryPattern
{
    public class SimpleFactory
    {
        private static IProduct Product;

        static SimpleFactory()
        {
            Product = new ComplexHouse();
        }

        public static IProduct GetInstance()
        {
            return Product;
        }
    }
}
