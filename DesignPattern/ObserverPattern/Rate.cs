using System.Collections.Generic;

namespace DesignPattern.ObserverPattern
{
    public abstract class Rate
    {
        protected IList<ICompany> Companys = new List<ICompany>();
        //增加观察者方法
        public void Add(ICompany company)
        {
            Companys.Add(company);
        }
        //删除观察者方法
        public void Remove(ICompany company)
        {
            Companys.Remove(company);
        }
        public abstract void Change(int number);
    }
}
