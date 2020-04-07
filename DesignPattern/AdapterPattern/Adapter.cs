using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AdapterPattern
{
    public class Adapter : Adaptee, ITarget
    {
        public void Request()
        {
            Console.WriteLine("我是类适配器实现了接口，下面是我包的一层");
            SepcialRequest();
        }
    }

    public class ObjectAdater : ITarget
    {
        //1.内部默认构建
        //private readonly Adaptee Adaptee = new Adaptee();

        private readonly Adaptee Adaptee;
        //2.构造函数构建
        public ObjectAdater(Adaptee adaptee)
        {
            Adaptee = adaptee;
        }

        //3.属性构建  要清楚步骤 先实例化 不安全
        //public Adaptee Adaptee { get; set; }
        public void Request()
        {
            Console.WriteLine("我是对象适配器实现了接口，下面是我包的一层");
            Adaptee.SepcialRequest();
        }
    }
}
