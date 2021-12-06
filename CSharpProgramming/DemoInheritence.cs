using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("Constructor of BaseClass called");
        }
        ~BaseClass()
        {
            Console.WriteLine("Destructor of BaseClass called");
        }
    }
    class DerivedClass:BaseClass
    {
        public DerivedClass()
        {
            Console.WriteLine("Constructor of DerivedClass called");
        }
        ~DerivedClass()
        {
            Console.WriteLine("Destructor of DerivedClass called");
        }
    }
    class ChildClass:DerivedClass
    {
        public ChildClass()
        {
            Console.WriteLine("Constructor of ChildClass called");
        }
        ~ChildClass()
        {
            Console.WriteLine("Destructor of ChildClass called");
        }
    }

    class DemoInheritence
    {
        static void Main(string[] args)
        {
            //BaseClass baseObj = new BaseClass();


            //DerivedClass dervObj = new DerivedClass();

            ChildClass childObj = new ChildClass();

            Console.Read();
        }
    }
}
