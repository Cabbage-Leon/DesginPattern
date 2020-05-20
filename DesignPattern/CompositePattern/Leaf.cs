using System;

namespace DesignPattern.CompositePattern
{
    //树叶构件（Leaf）角色：是组合中的叶节点对象，它没有子节点，用于实现抽象构件角色中 声明的公共接口。
    public class Leaf : IComponent
    {
        private readonly string Name;
        public Leaf(string name)
        {
            this.Name = name;
        }

        public void Add(IComponent component)
        {
            throw new NotImplementedException();
        }
        public void Remove(IComponent component)
        {
            throw new NotImplementedException();
        }

        public void Operation()
        {
            Console.WriteLine("树叶" + Name + "：被访问！");
        }


    }
}
