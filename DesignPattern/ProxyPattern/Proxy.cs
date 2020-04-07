using System;

namespace DesignPattern.ProxyPattern
{
    //代理一个实例  实例有多种注入方式
    public class Proxy : Subject
    {
        private Subject Subject;

        public Proxy(Subject subject)
        {
            this.Subject = subject;
        }

        public void Request()
        {
            PreRequest();
            Subject.Request();
            PostRequest();
        }

        public void PreRequest()
        {
            Console.WriteLine("访问真实主题之前的预处理");
        }
        public void PostRequest()
        {
            Console.WriteLine("访问真实主题之后的后续处理");
        }
    }
}
