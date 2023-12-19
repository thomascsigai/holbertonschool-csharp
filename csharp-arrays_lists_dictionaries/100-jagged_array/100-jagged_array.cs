using System;

class Program
{
    static void Main(string[] args)
    {
        int[][] newArray = new int[3][];

        newArray[0] = new int [] {0, 1, 2, 3};
        newArray[1] = new int [] {0, 1, 2, 3, 4, 5, 6};
        newArray[2] = new int [] {0, 1};

        foreach (int[] item in newArray)
        {
            Console.Write(item[0]);
            for (int i = 1; i < item.Length; i++)
            {
                Console.Write($" {item[i]}");
            }
            Console.WriteLine();
        }
    }
}
