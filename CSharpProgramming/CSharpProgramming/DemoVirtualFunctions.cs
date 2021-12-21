using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    class MyVirtualClass
    {
        public virtual void Function1()
        {
            Console.WriteLine("Inside the virtual function called Function1() in MyVirtualClass");
        }
    }

    class Myclass:MyVirtualClass
    {
        public void F1()
        {
            Console.WriteLine("F1() method in MyClass");
        }
        public override void Function1()
        {
            Console.WriteLine("Inside the virtual function overridden in the MyClass");
        }

    }
    class DemoVirtualFunctions
    {
        static void Main(string[] args)
        {
            //MyVirtualClass obj = new MyVirtualClass();
            //obj.Function1();
            //Console.WriteLine("***************************************");
            //Myclass myclassObj = new Myclass();
            //myclassObj.F1();
            //myclassObj.Function1();
            Console.WriteLine("***************************************");
            MyVirtualClass obj = new Myclass();
            obj.Function1();
            Console.Read();
        }
    }
}
