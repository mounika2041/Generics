using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Day13
{
    class FindMaxUsingGenericsMethod
    { 
        public static T printMaxValue<T>(T first,T second,T third) where T:IComparable
        { 
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("first is having Max value");
                return first;
            }

            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("second is having Max value");
                return second;
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                Console.WriteLine("third is having Max Value");
                return third;
            }
            else
            {
                return default;
            }
        }
    }
}
