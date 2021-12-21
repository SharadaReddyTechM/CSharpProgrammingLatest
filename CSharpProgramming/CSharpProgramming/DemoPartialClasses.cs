using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    class DemoPartialClasses
    {
        static void Main(string[] args)
        {
            //MyPartialClass obj = new MyPartialClass();
            int age = 10;
            age = -878;
            //age = null;//error

            int? age1 = null;//nullable type or nullable integer variable
            age1 = 3434;
            age1 = null;

            // int b = age;

            //int b = (int)age1;
            //int b=0;
            //Whenever nullable type values are to be stored in normal respective value type datatypes, we need to type cast the value.
            //but a null value which is stored in nullable type cannot be converted into an integer, there by landing in an exception.
            //so to avoid exception, we need to check the condition and then only convert.
            //if (age1 != null)
            //    b = (int)age1;
            //Console.WriteLine("The age value from variable b = "+b);

            //Coalesce Operator(??): this is an operator introduced in .net framework 3.5, for checking the values stored in a nullable type data type.
            age1 = 23;
            int b1 = age1 ?? 20;
            Console.WriteLine("The age value from variable b1 = " + b1);

            //string str = null;
            //str = "hello";
            //str = "strings can store null in them";
            //str = "Because by default they are reference types";



            Console.Read();
        }
    }
}
