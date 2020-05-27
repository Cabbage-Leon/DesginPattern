namespace DesignPattern.StatePattern
{
    public class ConcreteStateC : State
    {
        public ConcreteStateC(ScoreContext context)
        {
            _context = context;
            _stateName = "良好";
            _score = 0;
        }

        public ConcreteStateC(State state)
        {
            _context = state._context;
            _stateName = "良好";
            _score = state._score;
        }

        public override void CheckState()
        {
            if (_score >= 90)
            {
                //状态变更
                _context.State = new ConcreteStateB(this);
            }
            else if (_score < 60)
            {
                //状态变更
                _context.State = new ConcreteStateA(this);
            }
        }

    }
}
