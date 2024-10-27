using System;

class Program
{
    static void Main()
    {
        CreateLargeObjects();
        CreateSmallObjects();
    }

    static void CreateLargeObjects()
    {
        int[][] largeArray = new int[1000][];
        for (int i = 0; i < 1000; i++)
        {
            largeArray[i] = new int[10000];
            for (int j = 0; j < 10000; j++)
            {
                largeArray[i][j] = i + j;
            }
        }
        Console.WriteLine("Created large objects");
    }

    static void CreateSmallObjects()
    {
        int[] smallArray = new int[1000];
        for (int i = 0; i < 1000; i++)
        {
            smallArray[i] = i;
        }
        Console.WriteLine("Created small objects");
    }
}
