using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    interface IMicrophone
    {
        void Microphone();//function declaration
        //the default access specifier for any member (function) inside an interface is treated/taken as "public" and "abstract"
    }
    interface ICamera
    {
        void FrontCamera();
        void RearCamera();
    }
    //class MyClass
    //{
    //    void MyClassFn()//the default access specifier for any member(variable/function) inside class is treated/taken as "private"
    //    {

    //    }
    //}
    class Mobile : IMicrophone, ICamera
    {
        public void FrontCamera()
        {
            Console.WriteLine("FrontCamera() method implemented in Mobile Class");
        }

        public void Microphone()
        {
            Console.WriteLine("Microphone() method implemented in Mobile Class");
        }

        public void RearCamera()
        {
            Console.WriteLine("RearCamera() method implemented in Mobile Class");
        }
    }
    class Laptop : IMicrophone
    {
        public void Microphone()
        {
            Console.WriteLine("Microphone() method implemented in Laptop Class");
        }
    }
    class DemoInterfaces
    {
        static void Main(string[] args)
        {
            //IMicrophone obj = new IMicrophone();//error--> Cannot create an instance of the abstract type or interface 'IMicrophone'
            #region Demo Dynamic/Runtime Polymorphism using Interfaces


            //IMicrophone obj = new Mobile();
            //obj.Microphone();            
            //Console.WriteLine("********************************************************");
            //obj = new Laptop();
            //obj.Microphone();
            //Console.WriteLine("********************************************************");
            #endregion
            Console.WriteLine("********************************************************");
            #region Demo Multiple Inheritence in C# with Interfaces

            IMicrophone mobj = new Mobile();
            mobj.Microphone();

            ICamera cobj = new Mobile();
            cobj.FrontCamera();
            cobj.RearCamera();


            Mobile mob = new Mobile();
            mob.Microphone();
            mob.FrontCamera();
            mob.RearCamera();
            Console.WriteLine("********************************************************");
            #endregion

            
            Console.Read();
        }
    }


    

}
