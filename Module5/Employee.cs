using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
	//2. Have your employee class inherit the interface and implement a Quit() method
	public class Employee : Person, IQuittable
	{
		//Give the employee class a property called Id with data type integer
		public int Id { get; set; }
	}
	public void Quit()
	{
		throw new NotImplementedException();
	}
	
}
