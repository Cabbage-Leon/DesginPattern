using System;

namespace DesignPattern.BuilderPattern
{
    public class GoodBulider : Bulider
    {
        //构造函数创建
        //public GoodBulider(IProduct product)
        //{
        //    this.ComplexHouse = product;
        //}

        public override void One()
        {
            Console.WriteLine("第1步构造");
            this.ComplexHouse.Door = "门";
        }

        public override void Two()
        {
            Console.WriteLine("第2步构造");
            this.ComplexHouse.Desk = "桌子";
        }

        public override void Three()
        {
            Console.WriteLine("第3步构造");
            this.ComplexHouse.Floor = "地板";
        }


    }
}
