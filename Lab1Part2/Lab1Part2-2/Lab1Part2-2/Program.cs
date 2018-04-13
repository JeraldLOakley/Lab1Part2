using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Part2_2
{
	class Program
	{
		static void Main(string[] args)
		{
			//A simple message greeting the user 
			Console.WriteLine("Welcome to Time Span Calculator");
			//Explains the correct format for the calculator to except the date time
			Console.WriteLine("Please enter date in dd/mm/yyyy 23:59 format");
			//A blank line in the console, purely for aesthetic purposes
			Console.WriteLine();
			//Asking the reader to enter the first date
			Console.WriteLine("Enter first date");
			//Allows user to enter their first date and initializes that string value to the variable num1
			string num1 = Console.ReadLine();
			//Again purely aesthetic
			Console.WriteLine();
			//Asking the reader to enter the second date
			Console.WriteLine("Please enter second date");
			//Allows user to enter their second date and initializes that string value to the variable num2
			string num2 = Console.ReadLine();
			Console.WriteLine();

			/*These next two lines convert the string entered by the user to a DateTime datatype and initializes them to
			two new variables*/
			DateTime date1 = DateTime.Parse(num1);
			DateTime date2 = DateTime.Parse(num2);
			/*Here we are subtracting our two new DateTime variables using the TimeSpan method and initializing that 
			value to the difference variable*/
			TimeSpan difference = (date2 - date1);
			//Converting the difference variable into Days and initializing that value as an integer to the days variable
			int days = difference.Days;
			//Dividing the days variable by the typical days in a year and initializing that value to the integer variable Years
			int Years = (days / 365);
			/*By using the modulus operator here we will get the remainder of days from deviding days by a typical 
			  year and reassign that value to the days variable*/
			days = days % 365;
			//Dividing the days variable by a typical month in a year to get the amount of months between the two dates
			int Months = (days / 30);
			/*Again using the modulus operator to determine the amount of days remaining after the days variable
			  and a typical month are divided and reassigning that value again back to the days variable*/
			days = days % 30;

			//Here we are Writing a string to the console to identify and present our findings in Years, Months, Days, Hours, and Minutes
			Console.WriteLine("Years:" + Years);
			Console.WriteLine("Months:" + Months);
			Console.WriteLine("Days:" + days);
			Console.WriteLine("Hours:" + difference.Hours);
			Console.WriteLine("Minutes:" + difference.Minutes);
			//Allows the user to keep the console window open until they are ready to close it by entering any key
			Console.ReadLine();



		}

	}
}
