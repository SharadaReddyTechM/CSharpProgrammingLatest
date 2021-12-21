using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    abstract class GeometricShape
    {
        public abstract void Area();

        public abstract void Permiter();
        public void Show()
        {
            Console.WriteLine("Show() method in Geometric Shape");
        }
    }
    class Square : GeometricShape
    {
        int side;
        public Square()
        {
            this.side = 3;
        }
        public Square(int side)
        {
            this.side = side;
        }
        public override void Area()
        {
            Console.WriteLine("Area of Square = "+(side*side));
        }

        public override void Permiter()
        {
            Console.WriteLine("Perimeter of Square = "+(4*side));
        }
    }
    class Rectangle:GeometricShape
    {
        int length,breadth;
        public Rectangle()
        {
            this.length = 3;
            this.breadth = 5;
        }
        public Rectangle(int length,int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public override void Area()
        {
            Console.WriteLine("Area of Rectangle = " + (length * breadth));
        }
        public override void Permiter()
        {
            Console.WriteLine("Perimeter of Rectangle = " + (2*(length+breadth)));
        }
    }
    class DemoAbstractClassMethods
    {
        static void Main(string[] args)
        {
            //GeometricShape obj = new GeometricShape();//error

            GeometricShape obj = new Square();
            obj.Area();
            obj.Permiter();

            Console.WriteLine("****************************");

            obj = new Rectangle();
            obj.Area();
            obj.Permiter();

            Console.Read();
        }
    }
}
