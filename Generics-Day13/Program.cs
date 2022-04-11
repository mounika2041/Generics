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
            int x = 10, y = 20, z = 30;
            Console.WriteLine("{0} is having Max value out of{1},{2},{3}", FindMaxOfInteger.FindMaxValue(x, y, z), x, y, z);
            Console.ReadLine();
        }
    }
}
