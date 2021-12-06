using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    class FunctionsWithReturnValues
    {
        static void Main(string[] args)
        {
            int num = 124;
            bool chkPallindrome;
            //int result=Reverse(num,out chkPallindrome);
            int rev=0;
            Reverse(num, ref rev, out chkPallindrome);
            //Console.WriteLine("The reverse of the given number {0} is {1}",num,result);
            Console.WriteLine("The reverse of the given number {0} is {1}", num, rev);
            Console.WriteLine((chkPallindrome==true)?"The given number is pallindrome":"The given number is not pallindrome");
            Console.Read();
        }

        //Language/application neutral code
        //static int Reverse(int num,out bool isPallindrome)
        //{
        //    int rev = 0,temp=num;
        //    //bool isPallindrome = false;
        //    while(num!=0)
        //    {
        //        rev = rev * 10 + num % 10;
        //        num /= 10;
        //    }
        //    isPallindrome = (rev == temp) ? true : false;            
        //    return rev;
        //   // return isPallindrome;
        //}

        static void Reverse(int num, ref int rev,out bool isPallindrome)
        {
            rev = 0;
            int temp = num;
            //bool isPallindrome = false;
            while (num != 0)
            {
                rev = rev * 10 + num % 10;
                num /= 10;
            }
            isPallindrome = (rev == temp) ? true : false;           
        }
    }
}
