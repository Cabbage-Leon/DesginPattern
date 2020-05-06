using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.TemplateMethod
{
    /// <summary>
    /// 具体子类（Concrete Class）：实现抽象类中所定义的抽象方法和钩子方法，它们是一个顶级逻辑的一个组成步骤。
    /// </summary>
    public class ConcreteClass : AbsClass
    {
        public override void AbstractMethod1()
        {
            Console.WriteLine("实现类中的具体方法1被调用...");
        }

        public override void AbstractMethod2()
        {
            Console.WriteLine("实现类中的具体方法2被调用...");
        }
    }
}
