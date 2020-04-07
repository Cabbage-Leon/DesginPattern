using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BridgePattern
{
    public class RefinedAbstraction : Abstraction
    {

        //构造交给父
        public RefinedAbstraction(IIMplementor mplementor) : base(mplementor)
        {
            //这里就不许要了，可以做点别的
            //this.iMplementor = mplementor;
        }

        //不管父干了什么，因为他也没干的什么，活我自己干
        public override void Operation()
        {
            //在这里就可以用了
            this.iMplementor.OperationImpl();
        }
    }
}
