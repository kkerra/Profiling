namespace ReyRom
{
    public static class Recursion
    {
        public static int Fibonacci(int n)
        {
            if (n <= 1) return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
namespace kyzyalakomkin
{
    public static class Recursion
    {
        public static int Factorial(int n)
        {
            if (n <= 1) return n;
            return n * Factorial(n - 1);
        }
    }

}
