namespace DesignPattern.StatePattern
{
    public class ConcreteStateA : State
    {
        public ConcreteStateA(ScoreContext context)
        {
            _context = context;
            _stateName = "不及格";
            _score = 0;
        }

        public ConcreteStateA(State state)
        {
            _context = state._context;
            _stateName = "不及格";
            _score = state._score;
        }


        public override void CheckState()
        {
            //可以业务处理
            //。。。

            if (_score >= 90)
            {
                //状态变更
                _context.State = new ConcreteStateB(this);
            }
            else if (_score >= 60)
            {
                //状态变更
                _context.State = new ConcreteStateC(this);
            }
        }
    }
}
