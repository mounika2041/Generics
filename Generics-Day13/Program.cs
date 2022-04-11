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
            Console.WriteLine("1:find the max value of integers\n2:find the max value of floats\n3:find the max value of string\n 4:find max using generics method\n5:Find  Max using Generic Class\n6:Find max using Array Sort");
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
                case 3:
                    string s1 = "abc", s2 = "abc", s3 = "zbc";
                    Console.WriteLine("{0} is having Max value out of{1},{2},{3}", FindMaxOfString.FindMaxValue(s1, s2, s3), s1, s2, s3);
                    break;
                case 4:
                    int X = 120, Y = 100, Z = 80;
                    float F1= 22.34f,F2= 45.78f,F3= 9.54f;
                    string S1 ="abc", S2 ="abz", S3 ="zbc";
                    FindMaxUsingGenericsMethod.printMaxValue<int>(X, Y, Z);
                    FindMaxUsingGenericsMethod.printMaxValue<float>(F1, F2, F3);
                    FindMaxUsingGenericsMethod.printMaxValue<string>(S1, S2, S3);
                    break;
                case 5:
                    int k = 15, l = 34, m = 90;
                    new GenericsFindMax<int>(k, l, m).TestMaximum();
                    break;
                case 6:
                    int[] arr = { 10, 45, 26, 90 };
                    FindMaxUsingArraySortMethod<int> result = new FindMaxUsingArraySortMethod<int>(arr);
                    result.PrintMaxValue();
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
