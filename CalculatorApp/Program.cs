using System.ComponentModel;

void CalculatorApp()
{
	try
	{
		Console.WriteLine("Enter the first Number ");
		int firstNumber = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter the second number ");
		int secondNumber = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter the operation (+, -, *, /):");
		var operation= Convert .ToChar(Console.ReadLine());

		int result = 0; //declaring the int before use 


		switch (operation)
		{
			case '+':
				result = firstNumber + secondNumber; // the result was already delcare and put down as 0 
				break;

			case '-':
				result = firstNumber - secondNumber;
				break; 

			case '*':
				result = firstNumber * secondNumber;
				break;

			case '/':
				result = firstNumber / secondNumber;
				break; 
		}

		Console.WriteLine($"Result: {result}"); // Use the $ to output results in C#
	}
	catch (Exception ex ) // always put on exception 
	{
		Console.WriteLine($"Error: {ex.Message}. Please enter a valid operation. ");
		throw;
	}

} // call the app after this bracket 
CalculatorApp();