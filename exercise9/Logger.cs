using System;
using System.Collections.Generic;

namespace exercise_9
{
    class Logger
    {
        private List<string> messageList;

        public Logger()
        {
            messageList = new List<string>();
        }

        public void Log(string message)
        {
            messageList.Add(DateTime.Now.ToString() + " : " + message);
        }

        public void Print()
        {
            foreach (string message in messageList)
            {
                Console.WriteLine(message);
            }
        }
    }
}