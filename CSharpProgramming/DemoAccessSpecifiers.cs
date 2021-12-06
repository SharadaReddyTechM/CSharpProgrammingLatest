using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    class DemoAccessSpecifiers
    {
        static void Main(string[] args)
        {
            OwnClass obj = new OwnClass();
           // Console.WriteLine("Own Class Private Variable in Other Class = " + obj.pvtVar);
            Console.WriteLine("Own Class Public Variable in Other Class = " + obj.pubVar);
           // Console.WriteLine("Own Class Protected Variable in Other Class = " + obj.protVar);
            Console.WriteLine("Own Class Internal Variable in Other Class = " + obj.internVar);
            Console.WriteLine("Own Class Protect Internal Variable in Other Class = " + obj.protInternVar);
            Console.WriteLine("*****************************************************");
        }
    }
    class OwnClass
    {
        int pvtVar;
        public int pubVar;
        protected int protVar;
        internal int internVar;
        protected internal int protInternVar;
    }
    class DerivedClassNS:OwnClass
    {
        void Assign()
        {
           //pvtVar = 20;//error-->OwnClass.pvtVar is inaccessible due to its protection level
            pubVar = 20;
            protVar = 20;
            protInternVar = 30;
            internVar = 90;
        }
        void Print()
        {
            //Console.WriteLine("Own Class Private Variable in Derived Class = " + pvtVar);//error-->OwnClass.pvtVar is inaccessible due to its protection level
            Console.WriteLine("Own Class Public Variable in Derived Class = "+pubVar);
            Console.WriteLine("Own Class Protected Variable in Derived Class = "+protVar);
            Console.WriteLine("Own Class Internal Variable in Derived Class = "+internVar);
            Console.WriteLine("Own Class Protect Internal Variable in Derived Class = "+ protInternVar);
            Console.WriteLine("*****************************************************");
        }
    }
}
