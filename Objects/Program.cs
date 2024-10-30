﻿using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.WriteLine("Starting memory analysis...");

        // Создание объектов большой размерности
        Stopwatch stopwatch = Stopwatch.StartNew();
        CreateLargeObjects();
        stopwatch.Stop();
        Console.WriteLine($"Создание объектов большой размерности: {stopwatch.ElapsedMilliseconds} ms");


        // Создание объектов маленькой размерности
        stopwatch = Stopwatch.StartNew();
        CreateSmallObjects();
        stopwatch.Stop();
        Console.WriteLine($"Создание объектов маленькой размерности: {stopwatch.ElapsedMilliseconds} ms");

        // Создание объектов типа строк
        stopwatch = Stopwatch.StartNew();
        CreateStringObjects();
        stopwatch.Stop();
        Console.WriteLine($"Создание объектов типа строк: {stopwatch.ElapsedMilliseconds} ms");


        // Создание списков и коллекций
        stopwatch = Stopwatch.StartNew();
        CreateCollections();
        stopwatch.Stop();
        Console.WriteLine($"Создание списков и коллекций: {stopwatch.ElapsedMilliseconds} ms");

        Console.WriteLine("Memory analysis completed.");
    }

    static void CreateLargeObjects()
    {
        // Создаем большой двухмерный массив
        int[,] largeArray = new int[1000, 1000];
        for (int i = 0; i < 1000; i++)
        {
            for (int j = 0; j < 1000; j++)
            {
                largeArray[i, j] = i + j;
            }
        }
        Console.WriteLine("Created large 2D array.");
    }

    static void CreateSmallObjects()
    {
        // Создаем много маленьких объектов
        int[] smallArray = new int[100];
        for (int i = 0; i < 100; i++)
        {
            smallArray[i] = i;
        }
        Console.WriteLine("Created small array.");
    }

    static void CreateStringObjects()
    {
        // Создаем строки разной длины
        string shortString = "Short string";
        string longString = new string('A', 10000); // Длинная строка длиной 10,000 символов

        Console.WriteLine("Created short and long strings.");
    }

    static void CreateCollections()
    {
        // Создание списка объектов
        List<int[]> listOfArrays = new List<int[]>();
        for (int i = 0; i < 100; i++)
        {
            int[] array = new int[1000];
            for (int j = 0; j < array.Length; j++)
            {
                array[j] = j;
            }
            listOfArrays.Add(array);
        }

        // Создание словаря с большими строками
        Dictionary<int, string> largeDictionary = new Dictionary<int, string>();
        for (int i = 0; i < 1000; i++)
        {
            largeDictionary[i] = new string('B', 1000); // Строка длиной 1000 символов
        }

        Console.WriteLine("Created collections with arrays and dictionary.");
    }
}
