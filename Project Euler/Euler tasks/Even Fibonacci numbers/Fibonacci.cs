using System;
using System.Collections.Generic;
using System.Text;

namespace EulerTasks.Tasks.Even_Fibonacci_numbers
{
    public static class Fibonacci
    {
        public static int FindSum(int range)
        {
            int first = 0;
            int second = 1;
            int fibonacciNumber = 0;
            int sum = 0;

            while (fibonacciNumber <= range)
            {
                if (fibonacciNumber % 2 == 0)
                {
                    sum += fibonacciNumber;
                }

                fibonacciNumber = first + second;
                first = second;
                second = fibonacciNumber;
            }

            return sum;
        }
    }
}
