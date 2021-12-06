using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming
{
    class DemoWorkingWithClasses
    {
        static void Main(string[] args)
        {
			//create a Person class object
			//<classname> <objectname> = new <classname>();
			Person person1 = new Person("Rajesh","Kumar","9876599880",23,'m');
   //         Console.WriteLine("Accepting Person Details\n**********************");
			//person.SetDetails();
   //         Console.WriteLine("Displaying First Person Details\n***********************");
			//person1.ShowDetails();
			//person.fname = "rajesh";//error-->Inaccessible due its protection level
			//Console.WriteLine(person);//here person is an object of the class Person

			Person person2 = new Person("Rakesh", "Roshan", "9115699880",'m');
			//Console.WriteLine("Displaying Second Person Details\n***********************");
			//person2.ShowDetails();

			Person person3 = new Person("Ramesh", "Jhadhav", "7895699880");
            //Console.WriteLine("Displaying Third Person Details\n***********************");
            //person3.ShowDetails();


            Console.WriteLine(person1);//Console.WriteLine(person1.ToString());
			Console.WriteLine(person2);//Console.WriteLine(person2.ToString());
			Console.WriteLine(person3);//Console.WriteLine(person3.ToString());

			Console.Read();
        }
    }
	class Person
	{
		string fname, lname, mobile;
		int age;
		char gender;
        #region Constructor Definitions

        public Person()
        {
            Console.WriteLine("Default or Zero Argument Constructor called");
        }
		public Person(string fname, string lname)
		{
			Console.WriteLine("2 Argument Constructor called");
			this.fname = fname;
			this.lname = lname;			
		}
		public Person(string fname, string lname, string mobile)
		{
			Console.WriteLine("3 Argument Constructor called");
			this.fname = fname;
			this.lname = lname;
			this.mobile = mobile;			
		}
		public Person(string fname, string lname, string mobile,char gender)
		{
			Console.WriteLine("4 Argument Constructor called");
			this.fname = fname;
			this.lname = lname;
			this.mobile = mobile;			
			this.gender = gender;
		}
		public Person(string fname, string lname, string mobile, int age)
		{
			Console.WriteLine("4 Argument Constructor called");
			this.fname = fname;
			this.lname = lname;
			this.mobile = mobile;
			this.age = age;
		}
		public Person(string fname, string lname, string mobile,int age,char gender)
		{
			Console.WriteLine("5 Argument Constructor called");
			this.fname = fname;
			this.lname = lname;
			this.mobile = mobile;
			this.age = age;
			this.gender = gender;
		}

        #endregion
        #region Member Methods
		public void SetDetails()
		{
			Console.WriteLine("Please enter your Firstname ");
			fname = Console.ReadLine();

			Console.WriteLine("Please enter your Lastname");
			lname = Console.ReadLine();

			Console.WriteLine("Please enter your gender");
			gender = Convert.ToChar(Console.ReadLine());

			Console.WriteLine("Please enter your Age");
			age = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Please enter your 10-digit mobile number");
			mobile = Console.ReadLine();

		}
		public void ShowDetails()
		{
			Console.WriteLine("Person First Name : " + this.fname);
			Console.WriteLine("Person Last Name : "+this.lname);
			Console.WriteLine("Person Gender : "+this.gender);
			Console.WriteLine("Person Age : "+this.age);
			Console.WriteLine("Person Mobile : "+this.mobile);
            Console.WriteLine("***********************");
		}
        #endregion
        //override the ToString();
        public override string ToString()
        {
            return "Person First Name : " + this.fname+
			"\nPerson Last Name : " + this.lname+
			"\nPerson Gender : " + this.gender+
			"\nPerson Age : " + this.age+
			"\nPerson Mobile : " + this.mobile+
			"\n***********************";
		}
    }
}
