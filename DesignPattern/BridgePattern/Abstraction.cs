using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BridgePattern
{
    //我需要产品，具体那个产品我不关心，但是我就是要
    public abstract class Abstraction
    {
        public IIMplementor iMplementor;

        public Abstraction(IIMplementor mplementor)
        {
            iMplementor = mplementor;
        }

        //我这个留给子去做，我自己啥都不用了      与 装饰的不同在于  装饰者会先做一些事，然后让子也可以自由发挥，  相同就是都代理了，
        public abstract void Operation();
    }
}
