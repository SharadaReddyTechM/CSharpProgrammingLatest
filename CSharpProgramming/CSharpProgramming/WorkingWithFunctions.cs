using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    class WorkingWithFunctions
    {
        static void Main(string[] args)
        {
            MathOperations.CheckEvenNumber();

            //Create Object of MathOperation
            MathOperations mathObj = new MathOperations();
            //using the object, call the funtion/method
            Console.WriteLine("*****************");
            mathObj.GetReveresedNumber();
            Console.Read();
        }
    }
    class MathOperations
    {
        public static void CheckEvenNumber()
        {
            Console.WriteLine("Please enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("the number is even");
            else
                Console.WriteLine("the number is odd");
            Console.WriteLine((num % 2 == 0) ? "The number is Even number" : "The number is Odd number");
        }

        public void GetReveresedNumber()
        {
            int num, rev = 0;
            Console.WriteLine("Please enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            while (num!=0)
            {
                rev = rev * 10 + num % 10;
                num /= 10;
            }
            Console.WriteLine("The reverese of the given number "+temp+" = "+rev);
        }
        static void Hello()
        {
            CheckEvenNumber();
        }
    }
}
