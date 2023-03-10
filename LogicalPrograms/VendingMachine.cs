using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class VendingMachine
    {
        int[] notes = { 1000, 500, 100, 10, 5, 2, 1 };
        public void GetChnage(int amount)
        {
            if (amount / notes[1]>=1&& amount != 0)
            {
                int change = amount / notes[1];
                count += change;
                Console.WriteLine(notes[i]+"----->>>"+change);
                amount -= notes[i] * change;
            }
            Console.WriteLine("Total number of notes" + count);
        }
    }
}
