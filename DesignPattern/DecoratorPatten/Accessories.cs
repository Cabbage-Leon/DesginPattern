using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DecoratorPatten
{
    public class Accessories :Decorator
    {
        public Accessories(IPhone phone) : base(phone)
        {

        }

        //我看不惯父亲的做法，我自己搞一搞
        public override void Photo()
        {
            //可以先把父亲做的也拿过来先用
            base.Photo();
            //再加一点自己的东西
            this.AddAccessories();
        }

        public void AddAccessories()
        {
            Console.WriteLine("我给手机弄个挂件 ");
        }
    }
}
