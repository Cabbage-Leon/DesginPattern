using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StrategyPattern
{
    /// <summary>
    /// 具体策略（Concrete Strategy）类：实现了抽象策略定义的接口，提供具体的算法实现。
    /// </summary>
    public class ConcreteStrategyB : IStrategy
    {
        public void StrategyMethod()
        {
            Console.WriteLine("具体策略B的策略方法被访问！");
        }
    }
}
