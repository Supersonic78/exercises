using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extra_exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringInput = new string[] { "Hello", "Max", "Hi", "Hello" };
            string input = "    Hello H e l s i n g b o r g    !";

            Console.WriteLine($"Number of strings that equal 'Hello' is {CountHelloString(stringInput)}");
        }

        // Make a small method that takes an array of strings as input and 
        // returns the total number of items in the array that equals to “Hello”. 

        public static int CountHelloString(string[] strings)
        {
            int count = 0;

            foreach (string inputText in strings)
            {
                if (inputText == "Hello")
                {
                    count++;
                }
            }

            return count;
        }

        //We need a method that will filter out all the space characters from a given input string.
        //(do not use the string.replace method) 
        public static int EraseSpace(string strings)
        {
          strings.
        }


        //int inputCount = int.Parse(input.Count <[]>);
        //return(inputCount);
    
        }
    }
}
