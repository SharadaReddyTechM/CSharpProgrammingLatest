using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    class DemoJaggedArrays
    {
        static void Main(string[] args)
        {
            //declare a jagged array
            int[][] jagArr = new int[5][];
            int firstDimEle = jagArr.GetLength(0);

            for (int i = 0; i < firstDimEle; i++)
            {
                Console.WriteLine("please enter the no. of elements in {0} dimension",(i+1));
                int ele = Convert.ToInt32(Console.ReadLine());
                jagArr[i] = new int[ele];

                Console.WriteLine("Accepting elements for {0} row",(i+1));
                for (int j = 0; j < ele; j++)
                {
                    Console.WriteLine("Please enter {0} element",(j+1));
                    jagArr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < firstDimEle; i++)
            {
                for (int j = 0; j < jagArr[i].GetLength(0); j++)
                {
                    if(jagArr[i][j]%2==0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(jagArr[i][j] + "\t");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write(jagArr[i][j] + "\t");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
