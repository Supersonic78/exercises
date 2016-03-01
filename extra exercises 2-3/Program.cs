using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extra_exercises_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] values = new int[] { 10, 50, 60, 70, 20, 10, 30, 40, 53, 12 };
            Calculation calc = new Calculation();
            int max = calc.GetMaxValueFromArray(values);
            Console.WriteLine(max);
            int min = calc.GetMinValueFromArray(values);
            Console.WriteLine(min);
            int average = calc.CalculateAverageValueFromArray(values);
            Console.WriteLine(average);
            
        }
        
    }
}
