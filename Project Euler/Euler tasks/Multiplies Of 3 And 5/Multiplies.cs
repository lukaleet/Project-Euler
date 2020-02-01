using System;
using System.Collections.Generic;
using System.Text;

namespace EulerTasks.Tasks.Multiples_of_3_and_5
{
    public static class Multiplies
    {
        public static int FindSum(int range)
        {
            int multipliesOfThree = 0;
            int multipliesOfFive = 0;
            int counter = 1;

            while (counter < range)
            {
                if (counter % 3 == 0)
                {
                    multipliesOfThree += counter;
                }
                else if (counter % 5 == 0)
                {
                    multipliesOfFive += counter;
                }

                counter++;
            }

            return multipliesOfThree + multipliesOfFive;
        }
    }
}
