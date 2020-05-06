using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ResponsibilityPattern
{
    /// <summary>
    /// 具体处理者（Concrete Handler）角色：实现抽象处理者的处理方法，判断能否处理本次请求，如果可以处理请求则处理，否则将该请求转给它的后继者。
    /// </summary>
    public class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(string request)
        {
            if (request == "two")
            {
                Console.WriteLine("具体处理者2负责处理该请求！");
            }
            else
            {
                if (GetNext() != null)
                {
                    GetNext().HandleRequest(request);
                }
                else
                {
                    Console.WriteLine("没有人处理该请求！");
                }
            }
        }
    }
}
