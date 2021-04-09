using System;

namespace Detyra_12
{
    class Program
    {
        static void Main(string[] args)
        {
			{
				Employee Premtim = new Employee();
				Premtim.PrintEmployee();
			}
		}

		class Employee
		{
			string firstName = "Premtim";
			string lastName = "Gerguri";
			int age = 18;
			char gender = 'M';
			int employeeNumber = 27560000;

			public void PrintEmployee()
			{
				Console.WriteLine($"First Name: {firstName}.");
				Console.WriteLine($"Last Name: {lastName}.");
				Console.WriteLine($"Age: {age}.");
				Console.WriteLine($"Gender: {gender}.");
				Console.WriteLine($"Unique Employee number: {employeeNumber}.");
			}
		}
	}
    
}
