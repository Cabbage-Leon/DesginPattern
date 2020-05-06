using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StrategyPattern
{
    /// <summary>
    /// 抽象策略（Strategy）类：定义了一个公共接口，各种不同的算法以不同的方式实现这个接口，环境角色使用这个接口调用不同的算法，一般使用接口或抽象类实现。
    /// </summary>
    public interface IStrategy
    {
       void StrategyMethod();    //策略方法
    }
}
