using EulerTasks.Tasks.Even_Fibonacci_numbers;
using EulerTasks.Tasks.Multiples_of_3_and_5;
using Project_Euler.Euler_tasks.Multiplies_Of_3_And_5;
using System;

namespace Output
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiplies.FindSum(1000));
            Console.WriteLine(MultipliesLINQ.FindSum(1000));
            Console.WriteLine(Fibonacci.FindSum(4000000));
        }
    }
}
