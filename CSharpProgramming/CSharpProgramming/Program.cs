using System;//System is the top level namespace.

namespace CSharpProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello All....");
            //Console.WriteLine("Welcome to C# Programming");
            #region Data types, Reading data from user and Displaying data to user
            //int age;
            //float height;
            //char gender;
            //string name;
            //double weight;

            //Console.WriteLine("Please enter your name");
            //name = Console.ReadLine();

            //Console.WriteLine("Please enter your age");
            //age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please enter your gender\n please enter m for male and f for female");
            //gender = Convert.ToChar(Console.ReadLine());

            //Console.WriteLine("Please enter your height");
            //height = Convert.ToSingle(Console.ReadLine());

            //Console.WriteLine("Please enter your weight");
            //weight = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("User Details\n**************");
            //Console.WriteLine("User Name:  " + name);
            //Console.WriteLine("User Age: " + age);
            //Console.WriteLine("User Gender: " + gender);
            //Console.WriteLine("User Height: " + height);
            //Console.WriteLine("User Weight: " + weight);
            #endregion

            #region Conditional Statements

            //Conditional Statement in C#
            //Console.WriteLine("Please enter any character");
            //char ch = Convert.ToChar(Console.ReadLine());
            //if(ch=='a'||ch=='A'|| ch == 'e'|| ch == 'E'|| ch == 'i'|| ch == 'I'|| ch == 'o'|| ch == 'O'|| ch == 'u'|| ch == 'U')
            //{
            //    Console.WriteLine(ch+" is a vowel");
            //}
            //else
            //    Console.WriteLine(ch+" is not a vowel");
            //Console.WriteLine("********************");
            //switch (ch)
            //{
            //    case 'a':
            //    case 'A':
            //    case 'e':
            //    case 'E':
            //    case 'i':
            //    case 'I':
            //    case 'o':
            //    case 'O':
            //    case 'u':
            //    case 'U':
            //        {
            //            Console.WriteLine(ch+" is a vowel");
            //            break;
            //        }
            //    default:
            //        Console.WriteLine(ch + " is not a vowel");
            //        break;
            //}
            #endregion

            Console.WriteLine("enter your gender as m for male and f for female");
            char gender = Convert.ToChar(Console.ReadLine());
            //gender = (char)Console.Read();
            if(gender=='m'||gender=='M')
                Console.WriteLine("User Gender = Male");
            else
                Console.WriteLine("User Gender = Female");

            Console.WriteLine((gender == 'm' || gender == 'M')? "User Gender = Male": "User Gender = Female");

            Console.ReadLine();
        }
    }
}
