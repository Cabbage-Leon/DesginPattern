namespace DesignPattern.VisitorPattern
{
    public class ConcreteElementB : Element
    {
        //主动接受访问
        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }

        public string Operation()
        {
            return "具体元素B的具体操作。";
        }
    }
}
