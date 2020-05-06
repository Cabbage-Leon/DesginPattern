using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.TemplateMethod
{
    /// <summary>
    /// 抽象类（Abstract Class）：负责给出一个算法的轮廓和骨架。它由一个模板方法和若干个基本方法构成。这些方法的定义如下。
    /// </summary>
    public abstract class AbsClass
    {
        //模板方法：定义了算法的骨架，按某种顺序调用其包含的基本方法。
        public void TemplateMethod() //模板方法
        {
            SpecificMethod();
            if (HookMethods())
            {
                AbstractMethod1();
            }
           
            AbstractMethod2();
        }

        public virtual bool HookMethods()//钩子方法：在抽象类中已经实现，包括用于判断的逻辑方法和需要子类重写的空方法两种。
        {
            return true;
        }
        public void SpecificMethod() //具体方法：在抽象类中已经实现，在具体子类中可以继承或重写它。
        {
            Console.WriteLine("抽象类中的具体方法被调用...");
        }
        public abstract void AbstractMethod1(); //在抽象类中申明，由具体子类实现。
        public abstract void AbstractMethod2(); //抽象方法2
    }
}
