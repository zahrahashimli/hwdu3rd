using System;
namespace task1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter your name:");
			string name = Console.ReadLine();

			Console.WriteLine("Enter your surname:");
			string surname = Console.ReadLine();

			Console.WriteLine("Enter your age:");
			int age = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter your weight:");
			double weight = double.Parse(Console.ReadLine());

			Console.WriteLine("Enter your height:");
			double height = Convert.ToDouble(Console.ReadLine());

			Person MyPerson = new Person(name, surname, age, weight, height);
			Console.WriteLine(MyPerson);
		}
	}
}