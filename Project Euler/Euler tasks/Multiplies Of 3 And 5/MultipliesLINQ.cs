using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Euler.Euler_tasks.Multiplies_Of_3_And_5
{
    public static class MultipliesLINQ
    {
        public static int FindSum(int range)
        {
            return Enumerable.Range(0, range).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
        }
    }
}
