using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods__Debugging_and_Troubleshooting_Code__Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello(Console.ReadLine());
        }
        static void Hello(string name)
        {
            Console.WriteLine("Hello, {0}!",name);
        }
    }
}
