using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
	public class Person
	{
		//Person class with two string data types
		public string FirstName { get; set; }
		public string LastName { get; set; }
		//Give the class a void method called SayName() that takes no paramaters and simply writes the person's full name to the console
		public void SayName()
		{
			Console.WriteLine("Name: " + this.FirstName + " " + this.LastName);
		}
	}
}
