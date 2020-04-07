using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactoryPattern
{
    public interface AbstractFactory1
    {
        IProduct1 CreateProduct1();

        IProduct2 CreateProduct2();

    }
}
