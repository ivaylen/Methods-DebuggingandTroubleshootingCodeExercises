using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int firstMax = GetMax(first, second);
            int max = GetMax(firstMax, third);

            Console.WriteLine(max);
            
        }
        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }
    }
}
