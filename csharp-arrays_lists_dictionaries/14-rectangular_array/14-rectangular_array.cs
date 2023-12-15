using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] newArray = new int[5,5];

        newArray[2, 2] = 1;

        for (int i = 0; i < 5; i++)
        {
            Console.Write(newArray[i, 0]);
            for (int j = 1; j < 5; j++)
                Console.Write(" {0}", newArray[i, j]);
            Console.WriteLine();
        }
    }
}
