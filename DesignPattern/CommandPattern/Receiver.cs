using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CommandPattern
{
    /// <summary>
    /// 实现者/接收者（Receiver）角色：执行命令功能的相关操作，是具体命令对象业务的真正实现者。
    /// </summary>
    public class Receiver
    {
        public void Action()
        {
            Console.WriteLine("接收者的action()方法被调用...");
        }
    }
}
