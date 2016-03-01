using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var myLogger = new Logger();
            myLogger.Log("First post");
            myLogger.Log("Second post");
            myLogger.Log("Third post");

            //Console.WriteLine(myLogger.LogPosts[0]);

            foreach (string logList in myLogger.LogPosts)
            {
                Console.WriteLine(logList);
            }
        }
        
    }
}
