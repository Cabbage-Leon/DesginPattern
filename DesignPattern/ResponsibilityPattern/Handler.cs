using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ResponsibilityPattern
{
    /// <summary>
    /// 抽象处理者（Handler）角色：定义一个处理请求的接口，包含抽象处理方法和一个后继连接。
    /// </summary>
    public abstract class Handler
    {
        private Handler Next;
        public void SetNext(Handler next)
        {
            this.Next = next;
        }
        public Handler GetNext()
        {
            return Next;
        }

        //处理请求的方法
        public abstract void HandleRequest(string request);
    }
}
