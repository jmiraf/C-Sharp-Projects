using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
	class Program
	{
		static void Main(string[] args)
		{

			//Struct Assignment, create an object of data type Number and assign an amount to it then print to the console
			Number num1 = new Number();
			num1.Amount = Convert.ToInt32("100");
			Console.WriteLine(num1.Amount);
			Console.ReadLine();
			
			//Module 6 Parsing Enums Assignment
			bool isvalid = false;
			while(!isvalid)
			{
				try
				{
					//Prompt the user to enter the current day of the week
					Console.WriteLine("What day is today?");
					string daytoday = Console.ReadLine();
					//Assign the value to a variable of the enum data type
					DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), daytoday);
					Console.WriteLine("Have a nice " + day);
					Console.ReadLine();
					isvalid = true;
				}
				catch (ArgumentException ex)
				{
					Console.WriteLine("Please enter an actual day of the week");
				}
			}
			//end of Module 6 assignment
			
			//Instantiate the MathOperation1 class
			MathOperation1 mathOp = new MathOperation1();
			//First parameter
			Console.WriteLine("Enter a number:");
			int num1 = Convert.ToInt32(Console.ReadLine());
			//second parameter
			Console.WriteLine("Enter a second number:");
			//Call method with 2 parameters
			int num2 = Convert.ToInt32(Console.ReadLine());
			int results = mathOp.MathOperation(num1, num2);
			Console.WriteLine(num1 + " + " + num2 + " = " + results);

			Console.ReadLine();

			//Instantiate the MathMethods2 class
			//MathMethods2 math1 = new MathMethods2();
			//Call the first method with an int parameter
			//Console.WriteLine(math1.MathOp(7));
			//Call the second method with a decimal parameter
			//Console.WriteLine(math1.MathOp(7.3m));
			//Call the third method with a string parameter
			//Console.WriteLine(math1.MathOp("7"));
			//Console.ReadLine();

			//Calling Method Assignment
			//Console.WriteLine("You've encoutered Grozyni the Brigand and he launches a surprise attack.");
			//Console.WriteLine("Input your defense stat:");
			//int defense = Convert.ToInt32(Console.ReadLine());
			//int enemy_damage = MathMethods.Defense(defense);
			//Console.WriteLine("You have taken " + enemy_damage + " HP of damage.");
			//Console.WriteLine("Your healer, Serra is nearby. She heals you with her staff.");
			//Console.WriteLine("Input your healer's magic stat:");
			//int magic = Convert.ToInt32(Console.ReadLine());
			//int hitpoints = MathMethods.Heal(magic);
			//Console.WriteLine("You have been healed for " + hitpoints + "HP.");
			//Console.WriteLine("Now it's your turn to counter attack.");
			//Console.WriteLine("Input your strength stat:");
			//int strength = Convert.ToInt32(Console.ReadLine());
			//int damage = MathMethods.Attack(strength);
			//Console.WriteLine("You have landed a critical attack and dealt " + damage + " HP worth of damage.");
			//Console.ReadLine();
		}
		public enum DaysOfTheWeek
		{
			Monday,
			Tuesday,
			Wednesday,
			Thursday,
			Friday,
			Saturday,
			Sunday
		}
	}
}
