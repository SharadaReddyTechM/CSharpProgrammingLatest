using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    class DemoWorkingLooping
    {
        static void Main(string[] args)
        {
            //Ctrl + Shift + S --> Save all files
            //Ctrl + Shift + B --> to build/compile all files
            //Console.WriteLine("Please enter the number for which you would like to the multplication table");
            //int num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(num + " x " + i + " = " + (num * i));
            //}
            //Console.WriteLine("***********");
            //Console.WriteLine("Printing first 10 natural number Using For loop");
            //for (int j = 1; j <= 10; j++)
            //{
            //    Console.WriteLine(j+"\t");
            //}
            //Console.WriteLine("***********");
            Console.WriteLine("Printing first 10 natural number Using while loop");
            int i = 11;
            while (i<=10)
            {
                Console.WriteLine(i + "\t");
                i++;
            }

            Console.WriteLine("***********");
            i = 11;
            Console.WriteLine("Printing first 10 natural number Using do-while loop");
            do
            {
                Console.WriteLine(i + "\t");
                i++;
            } while (i<=10);

            Console.Read();
        }
    }
}
