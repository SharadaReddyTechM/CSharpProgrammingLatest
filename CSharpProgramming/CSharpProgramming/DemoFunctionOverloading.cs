using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    class DemoFunctionOverloading
    {
        static void Area()
        {

        }
        static void Area(int a)
        {

        }
        static void Area(int a,float b)//2 parameters;1-int and 1-float;int followed by float
        {

        }
        static void Area(float a, int b)//2 parameters;1-int and 1-float;float followed by int
        {

        }
        //return types will not be considered while deciding fn overloading concepts.
        //static float Area(float a, int b)//2 parameters;1-int and 1-float;float followed by int
        //{
        //    return 0.0f;
        //}
        static void Main(string[] args)
        {

        }
    }
}
