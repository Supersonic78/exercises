using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise3_r
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number");
            int inputNumber = int.Parse(Console.ReadLine());
            if (inputNumber < 0) // kontrollera om inmatningsnummer är negativt
            {
                Console.WriteLine("ERROR, NEGATIVE NUMBER!");
            }
            int sum = 0;
            for (int i = 1; i <= inputNumber; i++)
            {
                if (i < inputNumber)
                {
                    Console.Write(i + "+");
                    sum = sum + i;
                }
                else if (i == inputNumber)
                {
                    Console.Write(i);
                    sum = sum + i;
                    Console.Write("=" + sum);
                }                           
            }
            
            Console.ReadLine();
        }
    }
}
