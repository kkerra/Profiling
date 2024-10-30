using System.Diagnostics;

class Program
{
    static void Main()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        int result = ReyRom.Recursion.Fibonacci(40);
        stopwatch.Stop();
        Console.WriteLine($"Fibonacci(40) = {result}, время: {stopwatch.ElapsedMilliseconds}");

        stopwatch.Restart();
        result = kkerra.Recursion.Power(2, 20);
        Console.WriteLine($"Factorial(10) = {result}, время: {stopwatch.ElapsedMilliseconds}");
    }
}
