using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    class Test
    {
        static int count = 100;
        int x, y;
        //static Test()
        // {
        //     count = 100;
        //     x = 20;
        //     y = 30;
        // }
        public Test()
        {
            count++;
            x = 10;
            y = 20;
        }
        public override string ToString()
        {
            return "x value in Test Class = " + this.x +
                "\ny value in Test Class = " + this.y+
                "\ncount value in Test Class = "+count+
                "\n***********************************";
        }
    }    
    class DemoInheritenceAdv
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Object");
            Test obj1 = new Test();
            Console.WriteLine(obj1);
            Console.WriteLine("Second Object");
            Test obj2 = new Test();
            Console.WriteLine(obj2);
            Console.WriteLine("Third Object");
            Test obj3 = new Test();
            Console.WriteLine(obj3);

            Console.Read();
        }
    }
}
