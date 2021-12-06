using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    class DemoSealedClass
    {
        static void Main(string[] args)
        {
            ClassB obj = new ClassB();
            //obj.Func1();
            //obj.Func2();
            //obj.Func3();
            //obj.Func4();
            //obj.Func5();
            obj.Func6();
            obj.Func7();
            obj.Func8();
            obj.Func9();
            obj.Func10();

            obj.UseClassAMethods();

            Console.Read();
        }
    }
    class MyNewClass
    {
        public virtual void MyNewFunction()
        {

        }
    }
   sealed class ClassA:MyNewClass
    {
        public sealed override void MyNewFunction()
        {
            Console.WriteLine("MyNewClass MyNewFunction overridden in ClassA");
        }
        public void Func1()
        {

        }
        public void Func2()
        {

        }
        public void Func3()
        {

        }
        public void Func4()
        {

        }
        public void Func5()
        {

        }
    }
    class ClassB 
    {
        public void UseClassAMethods()
        {
            //object of sealed class
            ClassA obj = new ClassA();
            obj.Func1();
            obj.Func2();
        }
        public void Func6()
        {

        }
        public void Func7()
        {

        }
        public void Func8()
        {

        }
        public void Func9()
        {

        }
        public void Func10()
        {

        }
    }
}
