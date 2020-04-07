using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DecoratorPatten
{

    //我继承了父 ，拥有了父的一切  也成为了手机代理
    public class Sticker : Decorator
    {
        public Sticker(IPhone phone) : base(phone)
        {

        }

        //我看不惯父亲的做法，我自己搞一搞
        public override void Photo()
        {
            //可以先把父亲做的也拿过来先用
            base.Photo();
            //再加一点自己的东西
            this.AddSticker();
        }


        // 我想给他贴的膜
        public void AddSticker()
        {
            Console.WriteLine("我给手机弄个膜 ");
        }
    }
}
