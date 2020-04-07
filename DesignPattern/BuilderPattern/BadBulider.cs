using System;

namespace DesignPattern.BuilderPattern
{
    public class BadBulider : Bulider
    {
        public override void One()
        {
            Console.WriteLine("第1步构造");
            this.ComplexHouse.Door = "坏门";
        }

        public override void Two()
        {
            Console.WriteLine("第2步构造");
            this.ComplexHouse.Desk = "坏桌子";
        }

        public override void Three()
        {
            Console.WriteLine("第3步构造");
            this.ComplexHouse.Floor = "坏地板";
        }
    }
}
