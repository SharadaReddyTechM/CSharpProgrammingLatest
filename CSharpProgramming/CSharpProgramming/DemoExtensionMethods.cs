using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyNamespace;

namespace CSharpProgramming
{
    #region Commented Code   
    //class MyClass1
    //{
    //    public void Method1() { }
    //    public void Method2() { }
    //    public void Method3() { }
    //    public void Method4() { }
    //    public void Method5() { }
    //    public void Method6() { }
    //    public static void Method8()
    //    {

    //    }
    //}
    //class MyChildClass : MyClass1
    //{
    //    public void Method7()
    //    {

    //    }
    //}
    #endregion
    class DemoExtensionMethods
    {
        static void Main(string[] args)
        {
            //MyChildClass childObj = new MyChildClass();
            //MyClass1.Method8();//general way of invoking a static method--i.e. we use class name as the reference to invoke the static method.
            int num = 319;
            num.IsEven();//int.IsEven(num);
            int rev = 0;
            num.Reverse(ref rev);//int.Reverse(num,ref rev);
            Console.WriteLine("the reverse of the given number {0} = {1}", num, rev);
            //num.IsPallindrome();
            int sum = 0;

            string str = "hello all";
            //MyExtensionMethodsClass.CountVowels();
            int cnt = str.CountVowels();//string.CountVowels(str);
            Console.WriteLine("The number of vowels in \"{0}\" = {1}", str, cnt);

            int[] myArr = new int[] { 1, 3, 4, 6, 7, 8, 9, 11 };


            Console.Read();
        }
    }

}
namespace MyNamespace
{

    static class MyExtensionMethodsClass
    {
        public static void IsEven(this int n)
        {
            Console.WriteLine(n%2==0?"Number is Even":"Number is Odd");
        }

        public static int CountVowels(this string s)
        {
            int vowelsCount = 0;
            foreach (char ch in s.ToCharArray())
            {
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
                    vowelsCount++;
            }            
            return vowelsCount;
        }

        public static void Reverse(this int num,ref int reverse)
        {
            reverse = 0;
            while (num!=0)
            {
                reverse = reverse * 10 + num % 10;
                num /= 10;
            }
            Console.WriteLine("The reverse of the number in Reverse Extension method = "+reverse);
        }
    }
}
