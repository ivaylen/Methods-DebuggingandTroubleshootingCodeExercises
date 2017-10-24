using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _14.Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = Factorial(n);
            int zeroes = TrailingZeroes(factorial);
            Console.WriteLine(zeroes);
        }

        static int TrailingZeroes(BigInteger num)
        {
            int zeroes = 0;
            bool hasZeroes = true;
            while (hasZeroes == true)
            {
                BigInteger digit = num % 10;
                num /= 10;
                if (digit == 0)
                {
                    zeroes++;
                }
                else
                {
                    hasZeroes = false;
                }
            }
            return zeroes;
        }

        static BigInteger Factorial(int n)
        {
            BigInteger sum = 0;

            if (n == 1)
            {
                return 1;
            }
            else
            {
                sum = Factorial(n - 1) * n;
                return sum;
            }
        }
    }
}
