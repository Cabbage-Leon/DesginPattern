using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.PrototypePattern
{
    public class Realizetype : ICloneable
    {
        public Realizetype()
        {
            Console.WriteLine("具体原型被创建");
        }
        public object Clone()
        {
            Console.WriteLine("具体原型复制成功！");
            return (Realizetype)this.MemberwiseClone();
        }
    }
}
