using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise12
{
    class LogApplication
    {
        private ILogger _Log;
        public LogApplication(ILogger ilog)
        {
            _Log = ilog;
        }

        public void Run()
        {
            bool flag = true;
            while (flag)
            {

                Console.WriteLine("1) Add message to log ");
                Console.WriteLine("2) Print log ");
                Console.WriteLine("Choice:");
                int choiceInput = int.Parse(Console.ReadLine());


                switch (choiceInput)
                {
                    case 1:
                        Console.WriteLine("Type message to log");
                        string logInput = Console.ReadLine();
                        _Log.Log(logInput);
                        break;

                    case 2:
                        foreach (var logPost in _Log.LogPosts)
                        {
                            Console.WriteLine(logPost);
                        }
                        flag = false;
                        break;
                }
            }

        }
    }
}

