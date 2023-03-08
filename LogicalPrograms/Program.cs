using System;
namespace LogicalPrograms
{
    public class program
    {
        public static void Main(string[] args)
        {
            int a=0;
            int b=1;
            int c=1;
            Console.WriteLine(a);
            Console.WriteLine(b);
            while(true)
            {
                c = a + b;
                if (c >= 20)
                {
                    break;
                }
                Console.WriteLine(c);
                a = b;
                b = c;
            }
            Console.Read();
        }
    }
}