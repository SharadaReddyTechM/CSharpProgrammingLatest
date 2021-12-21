using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    class AdvanceCSFeatures
    {
        static void Main(string[] args)
        {
            #region MyRegion


            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            //C# is a strongly typed programming language
            //a variable must be declared with a particular data types, before we use.
            int num;
            num = 30;
            //from the table, one column value(multiple values), multiple column values,complete table data.
            //Implicitly Typed Variables(3.0)
            //'var' keyword 
            var n1 = 30;

            var msg = "hello";
            //var str;//error-->Implicitly - typed variables must be initialized  

            n1 = 890;
            //n1 = "hi";//error
            //5W 1H
            /*
            W - When
            W - What
            W - Where
            W - Why
            W - Who
            H - How
             */
            // n1 = "h";//once the implicitly typed variables gets their data type identified at compile time, we cannot reuse the variable for storing some other data typed values.

            int[] evenArray = new int[5];
            int[] oddArray = new int[5];
            int j = 0, k = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenArray[j] = arr[i];
                    j++;
                }
                else
                {
                    oddArray[k] = arr[i];
                    k++;
                }
            }
            Console.WriteLine("Even numbers of the array");


            Console.WriteLine("Odd numbers of the array");

            var evenNumbers = arr.Where(n => n % 2 == 0);
            var oddNumbers = arr.Where(n => n % 2 != 0);

            //dynamic--4.0

            dynamic sum = 89;
            // dynamic can be just declared and initialziation is not required
            // dynamic variables data type will be inferred(Type Inference) only at runtime.
            sum = "HEllo";
            sum = new Book();
            //dynamic variables can be reused for multiple purposes.
            //ViewBag.Title ="Index"
            //ViewBag.Prod=prd.ProductId
            //ViewData["prodID"]=prd.ProductId;
            #endregion
            //Object creation
            Book b1 = new Book();
            b1.BookID = 101;
            b1.BookName = "";
            b1.AuthorName = "";
            //Object Initializers-->3.0
            Book b2 = new Book { BookID = 102, BookName = "", AuthorName = "" };
            Book b3 = new Book { BookID = 103, BookName = "", AuthorName = "" };
            Book b4 = new Book { BookID = 104, BookName = "", AuthorName = "" };
            Book b5 = new Book { BookID = 105, BookName = "", AuthorName = "" };
            Book b6 = new Book { BookID = 106, BookName = "", AuthorName = "" };
            Book b7 = new Book { BookID = 107, BookName = "", AuthorName = "" };

            //Collection Initialization-Traditional 
            List<Book> bookList = new List<Book>();
            bookList.Add(b1);
            bookList.Add(b2);

            //Collection Initializers-->3.0
            List<Book> bukList = new List<Book> {
            new Book { BookID = 102, BookName = "", AuthorName = "" },
            new Book { BookID = 103, BookName = "", AuthorName = "" },
            new Book { BookID = 104, BookName = "", AuthorName = "" },
            new Book { BookID = 105, BookName = "", AuthorName = "" },
            new Book { BookID = 106, BookName = "", AuthorName = "" },
            new Book { BookID = 107, BookName = "", AuthorName = "" }
        };




        }
    }
    class Book
    {
        //Auto Implemented Properties-->3.0

        public int BookID { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }


    }
}
