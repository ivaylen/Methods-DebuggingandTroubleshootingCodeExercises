using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            GeometryFigures(figure);

        }
        private static void GeometryFigures(string figure)
        {
            switch (figure)
            {
                case"triangle":
                    Triangle();
                    break;
                case "square":
                    Square();
                    break;
                case"rectangle":
                    Rectangle();
                    break;
                case"circle":
                    Circle();
                    break;
            }


        }

        private static void Circle()
        {
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius,2);
            Console.WriteLine($"{area:F2}");
        }

        private static void Rectangle()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = width * height;
                Console.WriteLine($"{area:F2}");
        }

        private static void Square()
        {
            double side = double.Parse(Console.ReadLine());
            double area = side * side;
            Console.WriteLine($"{area:F2}");
        }

        private static void Triangle()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = side * height / 2;
            Console.WriteLine($"{area:F2}");
        }
    }
}
