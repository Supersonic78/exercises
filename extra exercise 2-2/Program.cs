using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extra_exercise_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tecken = 255;
            for (int i = 0; i < tecken; i++)
            {
                if (!(i % 40 == 0))
                    Console.Write((char)i + "|");
                else
                    Console.WriteLine();
            }
            

        }
    }
}
