using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AdapterPattern
{
    public class Adaptee
    {
        public void SepcialRequest()
        {
            Console.WriteLine("我是特殊的");
        }
    }
}
