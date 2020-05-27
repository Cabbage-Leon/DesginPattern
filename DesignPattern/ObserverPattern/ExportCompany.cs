using System;

namespace DesignPattern.ObserverPattern
{
    public class ExportCompany : ICompany
    {
        public void Response(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("人民币汇率升值" + number + "个基点，降低了出口产品收入，降低了出口公司的销售利润率。");
            }
            else if (number < 0)
            {
                Console.WriteLine("人民币汇率贬值" + (-number) + "个基点，提升了出口产品收入，提升了出口公司的销售利润率。");
            }
        }
    }
}
