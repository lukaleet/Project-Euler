using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Euler.Euler_tasks.Largest_prime_factor
{
    public static class Prime
    {
        public static int FindLargestFactor(long number)
        {
            int divider = 2;
            List<int> numbers = new List<int>();
            while(number != 1)
            {
                if (number % divider == 0)
                {
                    number /= divider;
                    if (IsPrime(divider))
                    {
                        numbers.Add(divider);
                    }
                }
                divider++;          
            }

            return numbers.Max();
        }

        public static bool IsPrime(int number)
        {
            int root = Convert.ToInt32(Math.Sqrt(number));
            for (int i = 2; i <= root; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
