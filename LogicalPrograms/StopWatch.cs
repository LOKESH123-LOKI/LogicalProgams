using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class StopWatch
    {
        public void run()
        {
            const string START = "Start", STOP = "Stop";
            Console.WriteLine("Enter 'Start to run the stop watch");
            string start= Console.ReadLine();
            TimeSpan timespan = TimeSpan.Zero;
            if (start.Equals(START))
            {
                int hour1=timespan.Hours;
                int minute1=timespan.Minutes;
                int second1=timespan.Seconds;
                int millisecond1=timespan.Milliseconds;

                Console.WriteLine("Enter 'Stop' to the end the stop watch");
                string stop = Console.ReadLine();
                if (stop.Equals(STOP))
                {
                    int hour2 = timespan.Hours;
                    int minute2 = timespan.Minutes;
                    int second2 = timespan.Seconds;
                    int microsecond2 = timespan.Milliseconds;
                    Console.WriteLine("Stop Watch Time"+(hour2-hour1)+":"+
                        (minute2-minute1)+":"+(second2-second1)+":"+(millisecond2 - millisecond1));
                }

            }
        }
    }
}
