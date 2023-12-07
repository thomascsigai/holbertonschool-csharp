using System;

class Line
{
	public static void PrintDiagonal(int length)
	{
		int i = 0;
		do
		{
			Console.Write(length > 0 ? new String(' ', i++) + "\\\n" : "");
		} while (i != length && length > 0);
		Console.Write("\n");
	}
}
