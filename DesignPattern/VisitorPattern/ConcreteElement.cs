namespace DesignPattern.VisitorPattern
{
    public class ConcreteElement : Element
    {
        //主动接受访问任意访问者访问
        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }

        public string Operation()
        {
            return "具体元素A的具体操作。";
        }
    }
}
