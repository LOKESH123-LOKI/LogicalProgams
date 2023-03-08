using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class FebinacciSeries
    {
        public void PrintSeries(int num)
        {
            int first = 0, second = 1, third = 0;
            Console.WriteLine(first + "\n" + second);
            for (int i=2; i<num; i++)
            {
                third = first + second;
                Console.WriteLine(third);
                first = second;
                second = first;
            }
        }
    }
}
