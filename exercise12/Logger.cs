using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise12
{
    class Logger:ILogger

    {
        public List<string> LogPosts{ get; set; }
        public void Log(string message)
        {
            LogPosts.Add(message);
        }
        public Logger()
        {
            LogPosts = new List<string>();
        }
        private List<string> List = new List<string>();

    
    }
}
