﻿using System;

class Number
{
	public static int PrintLastDigit(int number)
	{
		int lastDigit = Math.Abs(number) % 10;
		Console.Write("{0}", lastDigit);
		return lastDigit;
	}
}
