using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FacadePattern
{
    public class Facade
    {
        private SubSystem01 obj1 = new SubSystem01();
        private SubSystem02 obj2 = new SubSystem02();
        private SubSystem03 obj3 = new SubSystem03();
        public void Method()
        {
            obj1.Method1();
            obj2.Method2();
            obj3.Method3();
        }
    }
}
