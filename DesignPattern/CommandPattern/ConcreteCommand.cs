using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CommandPattern
{
    /// <summary>
    /// 具体命令角色（Concrete    Command）角色：是抽象命令类的具体实现类，它拥有接收者对象，并通过调用接收者的功能来完成命令要执行的操作。
    /// </summary>
    public class ConcreteCommand : ICommand
    {
        //代理这个类
        private Receiver Receiver;

        public ConcreteCommand()
        {
            this.Receiver = new Receiver();
        }

        public ConcreteCommand(Receiver receiver)
        {
            this.Receiver = receiver;
        }

        //这种情况又有点像适配器了
        public void Execute()
        {
            Receiver.Action();
        }
    }
}
