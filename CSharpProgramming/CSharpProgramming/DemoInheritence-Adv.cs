using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    class DemoInheritence_Adv
    {
        static void Main(string[] args)
        {
            //ParentClass p1Object = new ParentClass();
            //Console.WriteLine(p1Object);
            #region Matching Constructors invokation from Child and Parent Classes
            //ChildClass1 c1Object = new ChildClass1();
            //Console.WriteLine(c1Object);
            //Console.WriteLine("*********************************");
            //ChildClass1 c2Object = new ChildClass1(500);
            //Console.WriteLine(c2Object);
            //Console.WriteLine("*********************************");
            //ChildClass1 c3Object = new ChildClass1(500, 600);
            //Console.WriteLine(c3Object);
            //Console.WriteLine("*********************************");
            #endregion
            ChildClass1 childObject = new ChildClass1();
            childObject.Show();
            //childObject.Show();
            //childObject.Show(10);
            childObject.Display();

            ParentClass pObj = new ParentClass();
            pObj.Show();
            //pObj.Display();//Parent class objects cannot access the members of the child class, eventhough it has given inheritence to its child class.



            Console.ReadLine();
        }
    }
    class ParentClass
    {
        int x, y;
        public ParentClass()
        {
            Console.WriteLine("Parent Class 0 Argument Constructor called");
            this.x = 10;
            this.y = 10;
        }
        public ParentClass(int x)
        {
            Console.WriteLine("Parent Class 1 Argument Constructor called");
            this.x = x;
            this.y = x;
        }
        public ParentClass(int x, int y)
        {
            Console.WriteLine("Parent Class 2 Argument Constructor called");
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return "In Parent Class\nValue of x = " + x + "\nValue of y = " + y;
        }
        public void Show()
        {
            Console.WriteLine("Show() method in Parent Class");
        }

    }
    class ChildClass1 : ParentClass
    {
        int a, b;
        public ChildClass1() : base()
        {
            Console.WriteLine("Child Class 0 Argument Constructor called");
            this.a = 50;
            this.b = 50;
        }
        public ChildClass1(int a) : base(a)//base(3000)
        {
            Console.WriteLine("Child Class 1 Argument Constructor called");
            this.a = a;
            this.b = a;
        }
        public ChildClass1(int a, int b) : base(b, a)// base(a+1000,b+1000)
        {
            Console.WriteLine("Child Class 2 Argument Constructor called");
            this.a = a;
            this.b = b;
        }
        public override string ToString()
        {
            //string str = base.ToString();
            //Console.WriteLine(str);
            Console.WriteLine(base.ToString());
            return "In Child Class\nValue of a = " + a + "\nValue of b = " + b;
        }
        public new void Show()//here it throws a warning, saying that child class methods hides inherited member from the parent.
        {
            base.Show();
            Console.WriteLine("Show() method in Child Class");
        }
        public void Display()
        {
            Console.WriteLine("Display() in Child Class");
        }
        //public void Show(int a)
        //{
        //    Console.WriteLine("Show() method in Child Class");
        //}
    }
}
