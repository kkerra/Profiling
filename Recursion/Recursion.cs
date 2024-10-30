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
namespace kkerra
{
    public static class Recursion
    {
        public static int Power(int baseNum, int exponent)
        {
            if (exponent == 0) return 1;
            return baseNum * Power(baseNum, exponent - 1);
        }
    }

}
