using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
	class MathOperation1
	{
		//create a method that takes two integers as parameters
		public int MathOperation(int i, int j = 2)
		{
			//Have the method do a math operation on the first integer and display the second integer to the screen
			int result = i + j;
			return result;
		}
	}
}
