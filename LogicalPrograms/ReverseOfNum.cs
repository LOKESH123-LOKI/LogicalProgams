using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class ReverseOfNum
    {
        public void NumRevrse(int num)
        {
            int result = 0;
            while (num > 0)
            {
                int remainder= num % 10;
                result = result * 10 + remainder;
                num/= 10;
            }
            Console.WriteLine(result);
        }
    }
}
