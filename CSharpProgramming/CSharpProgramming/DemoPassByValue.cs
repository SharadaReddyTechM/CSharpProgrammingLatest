using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    class DemoPassByValue
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter any two numbers");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("In the Main Function before incrementing\n*******************");
            Console.WriteLine("Value in First Variable = {0}\nValue in Second Variable = {1}", n1, n2);
            Console.WriteLine("Calling the IncrementValues() method\n*******************");
            IncrementValues(n1,n2);

            Console.WriteLine("In the Main Function after incrementing\n*******************");
            Console.WriteLine("Value in First Variable = {0}\nValue in Second Variable = {1}", n1, n2);

            Console.Read();
        }
        static void IncrementValues(int val1,int val2)
        {
            val1 += 100;
            val2 += 100;
            Console.WriteLine("In the IncrementValues Function\n*******************");
            Console.WriteLine("Value in First Variable = {0}\nValue in Second Variable = {1}",val1,val2);
        }
    }
}
