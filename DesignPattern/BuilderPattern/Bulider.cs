namespace DesignPattern.BuilderPattern
{
    //构造者 实例化对象后分步构造 构造时必须先明确构造的内容，必须具体
    public abstract class Bulider
    {
        //这里是具体某个复杂对象，如果是一组，然后具体建造者中构造
        //public ComplexHouse IProduct Product { get; set; }

        //建造的对象放在里面是一组要用抽象对象 ， 放到外面就具体某一个对象
        //具体复杂对象 字段 内部构造
        //使用字段保护改对象 需要配合一个获取的实力的方法     如果使用属性直接点出来返回     相比而言字段更安全
        protected ComplexHouse ComplexHouse = new ComplexHouse();

        public abstract void One();//打地基
        public abstract void Two();//砌砖
        public abstract void Three();//粉刷

        public ComplexHouse GetComplexHouse()
        {
            ComplexHouse.Show();
            return ComplexHouse;
        }
    }
}
