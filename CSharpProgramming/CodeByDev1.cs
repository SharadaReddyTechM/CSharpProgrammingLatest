using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    partial class MyPartialClass
    {
        public void Fun1() { }
        public void Fun2() { }
        public void Fun3() { }
        public void Fun4() { }
        public void Fun5() { }

        public void UseFun10()
        {
            //MyPartialClass obj = new MyPartialClass();
            //obj.Fun10();


            MyPartialClass.Fun10();
        }
        static partial void Fun10()
        {

        }
    }
}
