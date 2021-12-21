using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    class DemoWorkingWithArrays
    {
        static void Main(string[] args)
        {
            //declare an array
            //int[] arr = new int[];//error
            //int[] arr = new int[] { 1, 2, 4 };//no error
            //int[] arr = { 1, 2, 3, 4, 5, 6 };//no error
            int size;
            Console.WriteLine("please enter no. of elements to be stored in array");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];

            Console.WriteLine("accepting array elements"); 
            Console.WriteLine("*************************");
            //the number of elements stored in a array
            int totElements = arr.Length;
            Console.WriteLine("Total Elements in an Array using Length = "+arr.Length);
            Console.WriteLine("Total Elements in an Array using GetLength() method = " + arr.GetLength(0));
            //for (int i = 0; i < totElements; i++)
            //{
            //    //Console.WriteLine("Please enter "+(i+1)+" element");//using concatenation operator
            //    Console.WriteLine("Please enter {0} element",(i+1));//using the execution sequence operator

            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            
            //Console.WriteLine("Displaying array elements");
            //Console.WriteLine("*************************");
            //for (int i = 0; i < totElements; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //Array.Sort(arr);
            //Console.WriteLine("Displaying sorted array elements");
            //Console.WriteLine("*************************");
            //for (int i = 0; i < totElements; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            Console.Read();
        }
    }
}
