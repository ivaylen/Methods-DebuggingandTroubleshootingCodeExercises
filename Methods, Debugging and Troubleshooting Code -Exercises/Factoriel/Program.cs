using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Factoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Result(n));
        }
        private static BigInteger Result(int n)
        {
            BigInteger sum = 0;
            if (n == 1)
            {
                return 1;
            }
            else
            {
                sum = Result(n - 1) * n;
                return sum;
            }
        }
    }
}
