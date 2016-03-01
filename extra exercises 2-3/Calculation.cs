using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extra_exercises_2_3
{
    class Calculation
    {
        public int GetMaxValueFromArray(int[] myArray)
        {
            int result = myArray[0];
            foreach (var item in myArray)
                if (item > result)
                {
                    result = item;
                }
            return result;
        }

        public int CalculateAverageValueFromArray(int[]myArray)
        {
            int sum = 0;
            foreach (var item in myArray)
            {
                sum += item;
            }
           
            return sum/myArray.Length;
            
        }
        public int GetMinValueFromArray(int[] myArray)
        {
            int result = myArray[0];
            foreach (var item in myArray)
                if (item < result)
                {
                    result = item;
                }
            return result;


        }
    }
}
