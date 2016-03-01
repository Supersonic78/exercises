using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extra_exercise2
{
    class NumberHelper
    {
        // NumberHelper.MaxValue(numbers)

        public static int MinValue(List<int> numberList)
        {
            int result = numberList[0];
            
            // numberList: -2, 2, -6
            foreach (int number in numberList)
            {
                if (number < result)
                    result = number;
            }

            return result;
        }

        public static int MaxValue(List<int> numberList)
        {
            int result = numberList[0];

            foreach (int number in numberList)
            {
                if (number > result)
                    result = number;
            }

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            Console.WriteLine("Input number 1");
            numbers.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("Input number 2");
            numbers.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("Input number 3");
            numbers.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine($"Max value is {NumberHelper.MaxValue(numbers)}");
            Console.WriteLine($"Min value is {NumberHelper.MinValue(numbers)}");
        }






        //public static int CompareNumbers(int a, int b, int c)
        //{
        //    if (a > b && a > c)
        //    {
        //        return a;
        //    }
        //    if (a < b && < c)
        //    {
        //        return a;
        //    }
        //    else { return 0; }



        //}
    }
}
