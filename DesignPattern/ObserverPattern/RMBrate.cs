namespace DesignPattern.ObserverPattern
{
    public class RMBrate : Rate
    {
        public override void Change(int number)
        {
            foreach (var company in Companys)
            {
                company.Response(number);
            }
        }
    }
}
