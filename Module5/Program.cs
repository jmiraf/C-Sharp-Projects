using System;

namespace Module5
{
	public class Program
	{
		static void Main(string[] args)
		{
			//3. Create an object of type IQuittable and call the Quit() method
			IQuittable employee = new Employee() { FirstName = "Jenilyn", LastName = "Mirafuente" };
			employee.Quit();
			Console.ReadLine();
		
			//instantiate and initialize an Employee object with first name and last name
			//Employee sam = new Employee() { FirstName = "Jenilyn", LastName = "Mirafuente" };
			//Call the superclass method SayName() on the employee object
			//sam.SayName();
			//Console.ReadLine();
		}
	}
}
