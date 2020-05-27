using System;

namespace DesignPattern.StatePattern
{
    public class ConcreteStateB : State
    {
        public ConcreteStateB(ScoreContext context)
        {
            _context = context;
            _stateName = "优秀";
            _score = 0;
        }

        public ConcreteStateB(State state)
        {
            _context = state._context;
            _stateName = "优秀";
            _score = state._score;
        }

        public override void CheckState()
        {
            if (_score >= 60 && _score <= 90)
            {
                //状态变更
                _context.State = new ConcreteStateC(this);
            }
            else if (_score < 60)
            {
                //状态变更
                _context.State = new ConcreteStateA(this);
            }
        }

    }
}
