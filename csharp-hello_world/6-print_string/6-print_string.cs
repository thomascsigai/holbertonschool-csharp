using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";
		Console.WriteLine(String.Concat(str, str, str));
		Console.WriteLine(str.Remove(9));
	}
}