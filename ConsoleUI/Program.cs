using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DemoLibrary;

namespace ConsoleUI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			PersonModel person = new PersonModel();

			Console.Write("What is your first name: ");
			person.FirstName = Console.ReadLine();
			Console.Write("What is your last name: ");
			person.LastName = Console.ReadLine();

			Console.WriteLine($"Hello {person.FullName}");

			_ = Console.ReadLine();
		}
	}
}
