using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PerfectNumber
    {
        public void MatchNumb(int num)
        {
            int result = 0;
            for (int i = 1, i < num; i++)
            {
                if (num % i == 0)
                    result += 1;
            }
            if (result == num)
                Console.WriteLine("Perfect number");
            else
                Console.WriteLine("Not perfect number");
        }
    }
}
