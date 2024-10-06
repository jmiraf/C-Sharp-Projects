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
			//Instantiate the MathMethods2 class
			MathMethods2 math1 = new MathMethods2();
			//Call the first method with an int parameter
			Console.WriteLine(math1.MathOp(7));
			//Call the second method with a decimal parameter
			Console.WriteLine(math1.MathOp(7.3m));
			//Call the third method with a string parameter
			Console.WriteLine(math1.MathOp("7"));
			Console.ReadLine();
			
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
	}
}
