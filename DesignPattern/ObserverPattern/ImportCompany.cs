using System;

namespace DesignPattern.ObserverPattern
{
    public class ImportCompany : ICompany
    {
        public void Response(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("人民币汇率升值" + number + "个基点，降低了进口产品成本，提升了进口公司利润率。");
            }
            else if (number < 0)
            {
                Console.WriteLine("人民币汇率贬值" + (-number) + "个基点，提升了进口产品成本，降低了进口公司利润率。");
            }
        }
    }
}
