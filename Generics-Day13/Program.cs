using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Day13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to generics");
            Console.WriteLine("please choose program number to execute");
            Console.WriteLine("1:find the max value of integers\n2:find the max value of floats\n3:find the max value of string");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    int x = 50, y = 20, z = 30;
                    Console.WriteLine("{0} is having Max value out of{1},{2},{3}", FindMaxOfInteger.FindMaxValue(x, y, z), x, y, z);
                    break;
                case 2:
                    float a = 12.34f, b = 45.78f, c = 90.54f;
                    Console.WriteLine("{0} is having Max value out of{1},{2},{3}", FindMaxOfFloat.FindMaxValue(a, b, c), a, b, c);
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
