using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DecoratorPatten
{
    //我是来装饰手机的，所以我要先有手机
    public abstract class Decorator : IPhone
    {
        private IPhone Phone;
        public Decorator(IPhone phone)
        {
            this.Phone = phone;
        }

        //这里是抽象类中 代理了手机， 可以扩展了手机的功能
        public virtual void Photo()
        {
            Phone.Photo();
        }
    }
}
