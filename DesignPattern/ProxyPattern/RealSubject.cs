using System;

namespace DesignPattern.ProxyPattern
{
    public class RealSubject : Subject
    {
        public void Request()
        {
            Console.WriteLine("发送请求");
        }
    }
}
