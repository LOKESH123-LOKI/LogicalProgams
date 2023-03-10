using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class CoupanNum
    {
        public void DistinctCoupan(int num)
        {
            int[]arr = new int[10];
            Random random = new Random();
            arr[0]=random.Next(0,num);
            for (int i = 1;i<=10;i++)
            {
                int coupan=random.Next(0,num);
                for(int  j = 1; j <= 1; j++)
                {
                    if (arr[i]!=coupan)
                    arr[i]=coupan;
                }
            }
        }
    }
}
