using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Day13
{
     class GenericsFindMax<T> where T : IComparable
     {            
        public T first, second, Third;
        public GenericsFindMax(T first, T second, T Third)
        {
                this.first = first;
                this.second = second;
                this.Third = Third;
        }
        public static T printMaxValue(T first, T second, T third)
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
                Console.WriteLine("may 2 or 3 variables are equal ");
                return default;
            }

        }
        public void TestMaximum()
        {
            T maxValue = printMaxValue(first, second, Third);
            Console.WriteLine("maxvalue is:" + maxValue);
        }
          
      
    }
}

