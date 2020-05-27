namespace DesignPattern.StatePattern
{
    /// <summary>
    /// 同样是包一层，不同的是在处理的时候，将自己的实例作为参数传给了具体的实现
    /// 状态的具体实例接管了上下文，做好自己的事情之后 还有可以更改上下文中的状态 
    /// context再次handle的时候，内部的状态就不一样了，这样也就实现了状态的传递
    /// </summary>
    public class ScoreContext
    {
        public State State { get; set; }

        //public ScoreContext()
        //{
        //}

        public ScoreContext()
        {
            State = new ConcreteStateA(this);
        }

        public ScoreContext(State state)
        {
            State = state;
        }

        public void Add(int x)
        {
            State.AddScore(x);
        }
    }
}
