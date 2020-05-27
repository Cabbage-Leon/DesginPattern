using System;

namespace DesignPattern.StatePattern
{
    public abstract class State
    {
        //所有具体的state共用一个context,所有具体的状态去逻辑判断后变更context中的状态就行，这也就实现的状态的传递
        public ScoreContext _context;  //环境
        public string _stateName; //状态名
        public int _score; //分数

        public void AddScore(int x)
        {
            _score += x;
            Console.WriteLine("加上：" + x + "分，\t当前分数：" + _score+ "分");
            CheckState();
            Console.WriteLine("\t当前状态：" + _context.State._stateName);
        }

        /// <summary>
        /// 这里是状态模式
        /// </summary>
        public abstract void CheckState(); //检查当前状态 


    }
}
