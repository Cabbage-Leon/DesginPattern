using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DecoratorPatten
{
    public class ApplePhone : IPhone
    {
        public string Name { get; set; } = "苹果手机";
        public void Photo()
        {
            Console.WriteLine(this.Name + "拍照");
        }

    }
}
