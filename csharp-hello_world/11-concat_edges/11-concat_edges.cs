﻿using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "C# (pronounced \"See Sharp\") is a simple, modern, object-oriented, and type-safe programming language. C# has its roots in the C family of languages and will be immediately familiar to C, C++, Java, and JavaScript programmers.";
		str = String.Concat(str.Split(' ')[8].Replace(',', ' '), str.Split(' ')[11], ' ', str.Split(' ')[17], ' ', str.Split(' ')[0]);
		Console.WriteLine(str);
    }
}