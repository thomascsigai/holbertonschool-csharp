using System;

class Character
{
	public static bool IsLower(char c)
	{
		bool returnValue = false;
		if (c >= 'a' && c <= 'z')
			returnValue = true;
		return returnValue;
	}
}
