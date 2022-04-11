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
            int k = 15, l = 34, m = 90;
            new GenericsFindMax<int>(k, l, m).TestMaximum();
            Console.ReadLine();
        }
    }
}
