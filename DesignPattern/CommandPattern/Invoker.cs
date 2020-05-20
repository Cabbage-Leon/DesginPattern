using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CommandPattern
{
    /// <summary>
    /// 调用者/请求者（Invoker）角色：是请求的发送者，它通常拥有很多的命令对象，并通过访问命令对象来执行相关请求，它不直接访问接收者。
    /// </summary>
    public class Invoker
    {
        //调用者代理命令-命令代理接受者-接受者具体实现
        private ICommand Command;

        public Invoker(ICommand command)
        {
            this.Command = command;
        }

        public void Call()
        {
            Console.WriteLine("调用者执行命令command...");
            Command.Execute();
        }
    }
}
