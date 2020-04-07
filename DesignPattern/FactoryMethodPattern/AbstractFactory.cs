using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryMethodPattern
{
    public interface AbstractFactory
    {
        IProduct CreateProduct();
    }
}
