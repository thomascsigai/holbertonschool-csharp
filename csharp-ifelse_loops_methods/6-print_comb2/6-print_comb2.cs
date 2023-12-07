using System;

class Program
{
	static void Main(string[] args)
	{
		for (int i = 0; i < 9; i++)
			for (int j = 1 + i; j < 10; j++)
				if (i + j != 17)
					Console.Write("{0}{1}, ", i, j);
		Console.WriteLine("89");
	}
}
