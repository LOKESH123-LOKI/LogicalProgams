using System;
using System.Collections.Generic;
using System.Globalization;
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
            DateTime timespan = DateTime.Now;
            if (start.Equals(START))
            {
                int hour1=timespan.Hour;
                int minute1=timespan.Minute;
                int second1=timespan.Second;
                int millisecond1=timespan.Millisecond;

                Console.WriteLine("Enter 'Stop' to the end the stop watch");
                string stop = Console.ReadLine();
                if (stop.Equals(STOP))
                {
                    DateTime timespan1 = DateTime.Now;
                    int hour2 = timespan1.Hour;
                    int minute2 = timespan1.Minute;
                    int second2 = timespan1.Second;
                    int microsecond2 = timespan1.Millisecond;
                    Console.WriteLine("Stop Watch Time"+(hour2-hour1)+":"+
                        (minute2-minute1)+":"+(second2-second1)+":"+(millisecond2 - millisecond1));
                }

            }
        }
    }
}
