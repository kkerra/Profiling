using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Task[] tasks = new Task[10];
        for (int i = 0; i < 10; i++)
        {
            int taskNumber = i;
            tasks[i] = Task.Run(() => PerformTask(taskNumber));
        }
        Task.WaitAll(tasks);
        Console.WriteLine("All tasks completed.");
    }

    static void PerformTask(int taskNumber)
    {
        double result = 0;
        for (int i = 0; i < 1000000; i++)
        {
            result += Math.Sqrt(i * taskNumber);
        }
        Console.WriteLine($"Task {taskNumber} completed with result {result}");
    }
}
