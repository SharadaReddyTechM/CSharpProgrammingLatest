using System;
using System.Collections;
using System.Collections.Generic;


namespace CSharpProgramming
{
    class WorkingWithCollections
    {
        static void Main(string[] args)
        {
            #region ArrayList Collection Class         
            //ArrayList arrlist = new ArrayList();

            ////adding items/elements into the Collection classes
            //int a = 10;
            //arrlist.Add(a);
            //arrlist.Add("Hello");
            //arrlist.Add(98.778f);
            //arrlist.Add(true);
            //arrlist.Add(new Person());
            //arrlist.Add(new Book());
            //arrlist.Add('c');
            //arrlist.Add(768.987);

            ////reading elements from collection class into other variables
            //int intElement = (int)arrlist[0];

            //string msg = arrlist[1].ToString();//(string)arrlist[1];

            //int b = (int)arrlist[0];

            //int[] arr = new int[3] { 10,20, 30 };
            //int element = arr[0];
            #endregion
            #region List Generic Collection Class
            //Integers List

            List<int> intLst = new List<int>();
            intLst.Add(100);
            intLst.Add(200);
            intLst.Add(400);
            intLst.Add(300);
            intLst.Add(800);
            intLst.Add(500);
            intLst.Add(700);
            intLst.Add(600);
            intLst.Add(900);

            // intLst.Add("Hello");//error

            List<string> strLst = new List<string>();
            strLst.Add("10");

            //displaying items in from list
            Console.WriteLine("With for Loop");
            int totElements = intLst.Count;
            for (int i = 0; i < totElements; i++)
            {
                Console.WriteLine(intLst[i]);
            }

            Console.WriteLine("With foreach Loop");
            foreach (var item in intLst)//IEnumerable interface
            {
                Console.WriteLine(item);
            }
            #endregion
            Console.Read();
        }
    }

    class Book
    {

    }
}
