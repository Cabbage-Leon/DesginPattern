namespace DesignPattern.FlyweightPattern
{
    //非享元（Unsharable Flyweight)角色：是不可以共享的外部状态，它以参数的形式注入具体享元的相关方法中。
    public class UnsharableFlyweight
    {
        private string Info;
        public UnsharableFlyweight(string info)
        {
            this.Info = info;
        }
        public string GetInfo()
        {
            return Info;
        }
        public void SetInfo(string info)
        {
            this.Info = info;
        }
    }
}
