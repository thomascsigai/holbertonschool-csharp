using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        int[] newArray;

        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        
        newArray = new int[size];

        for (int i = 0; i < size; i++)
            Console.Write(i == 0 ? "0" : " {0}", i);

        Console.WriteLine();

        return newArray;
    }
}
