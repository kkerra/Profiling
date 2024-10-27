using System;

class Program
{
    static void Main()
    {
        int result = Fibonacci(40);
        Console.WriteLine($"Fibonacci(40) = {result}");
    }

    static int Fibonacci(int n)
    {
        if (n <= 1) return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}
