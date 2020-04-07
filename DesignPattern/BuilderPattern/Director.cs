namespace DesignPattern.BuilderPattern
{
    public class Director
    {
        private Bulider Bulider;
        //构造函数注入 强依赖
        public Director(Bulider bulider)
        {
            Bulider = bulider;
        }

        public ComplexHouse Construct()
        {
            Bulider.One();
            Bulider.Three();
            Bulider.Two();
            return Bulider.GetComplexHouse() ;
        }

    }
}
