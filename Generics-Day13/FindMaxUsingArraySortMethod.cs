using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Day13
{
    class FindMaxUsingArraySortMethod<T> where T : IComparable
    {
        public T[] Values;

        public FindMaxUsingArraySortMethod(T[] Values)
        {
            this.Values = Values;
        }
        public T[] ArraySort()
        {
            Array.Sort(this.Values);
            return Values;
        }
        public T MaxValue()
        {
            ArraySort();
            int lastIndex = Values.Length - 1;
            return Values[lastIndex];
        }
        public T MaxMethod()
        {
            var Max = MaxValue();
            Console.WriteLine("MAX values is:" + Max);
            return Max;
        }

    }
}
    
    

