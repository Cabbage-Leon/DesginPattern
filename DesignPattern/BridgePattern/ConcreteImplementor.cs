using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BridgePattern
{
    //产品抽象的具体实现
    public class ConcreteImplementor : IIMplementor
    {
        public void OperationImpl()
        {
            Console.WriteLine("我是具体的产品");
        }
    }
}
