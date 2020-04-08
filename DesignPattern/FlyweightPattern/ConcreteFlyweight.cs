using System;

namespace DesignPattern.FlyweightPattern
{
    //具体享元（Concrete Flyweight）角色：实现抽象享元角色中所规定的接口。
    public class ConcreteFlyweight :IFlyweight
    {
        private readonly string Key;
        public ConcreteFlyweight(string key)
        {
            this.Key = key;
            Console.WriteLine("具体享元" + key + "被创建！");
        }

        public void Operation(UnsharableFlyweight unsharableFlyweight)
        {
            Console.WriteLine("具体享元" + Key + "被调用，");
            Console.WriteLine("非享元信息是:" + unsharableFlyweight.GetInfo());
        }

    }
}
