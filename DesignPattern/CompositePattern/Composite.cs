using System.Collections.Generic;

namespace DesignPattern.CompositePattern
{
    //树枝构件（Composite）角色：是组合中的分支节点对象，它有子节点。它实现了抽象构件角色中声明的接口，它的主要作用是存储和管理子部件，通常包含 Add()、Remove()、GetChild() 等方法。
    public class Composite : IComponent
    {
        private readonly List<IComponent> Components = new List<IComponent>();

        public void Add(IComponent c)
        {
            Components.Add(c);
        }

        public void Remove(IComponent c)
        {
            Components.Remove(c);
        }

        public void Operation()
        {
            foreach (var component in Components)
            {
                component.Operation();
            }
        }
    }
}
