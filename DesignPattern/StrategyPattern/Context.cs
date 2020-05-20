using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StrategyPattern
{
    /// <summary>
    /// 环境（Context）类：持有一个策略类的引用，最终给客户端调用。
    /// 本质就是代理，对外可以替换这个代理
    /// </summary>
    public class Context
    {
        private IStrategy Strategy { get; set; }

        /// <summary>
        /// 构造函数实例化
        /// </summary>
        /// <param name="strategy"></param>
        public Context(IStrategy strategy)
        {
            this.Strategy = strategy;
        }

        public void StrategyMethod()
        {
            Strategy.StrategyMethod();
        }

        /// <summary>
        /// 方法实例化
        /// </summary>
        /// <param name="strategy"></param>
        public void StrategyMethod(IStrategy strategy)
        {
            this.Strategy = strategy;
            Strategy.StrategyMethod();
        }
    }
}
