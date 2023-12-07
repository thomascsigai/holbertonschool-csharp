using System;

class Program
{
	static void Main(string[] args)
	{
		for (int i = 'a'; i <= 'z'; i++)
			if (i != 'q' && i != 'e')
				Console.Write("{0}", (char)i);
	}
}
