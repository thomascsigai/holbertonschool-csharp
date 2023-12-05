using System;
using System.Globalization;

class Program
{
	static void Main(string[] args)
	{
		double percent = .7553;
		double currency = 98765.4321;
		Console.WriteLine(String.Format(new CultureInfo("en-US.utf-8"), "Percent: {0:p2}\nCurrency: {1:c}", percent, currency));
	}
}