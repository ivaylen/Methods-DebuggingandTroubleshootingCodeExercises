using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(Fibonaci(n));
        }
        static long Fibonaci(long n)
        {
            long a = 1;
            long b = 0;
            for (int i = 0; i <= n; i++)
            {
                long c = b;
                b = b + a;
                a = c;
            }
            return b;

        }
    }
}
