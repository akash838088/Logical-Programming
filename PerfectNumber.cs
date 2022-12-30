using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PerfectNumber
    {

        public static void FindNumbers()
        {

            int n, i, sum;
            int mn, mx;

            Console.WriteLine("the perfect number within a given number of range");

            Console.WriteLine("Input the starting range of number");

            mn=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the ending range of number");

            mx=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Te pefect number within the given range");

            for(n=mn; n<=mx; n++)
            {
                i = 1;
                sum = 0;
                while(i<n)
                {
                    if (n % i == 0)
                        sum = sum + 1;
                    i++;
                }
                if (sum == n)
                    Console.Write("{0}", n);
            }
        }
    }
}
