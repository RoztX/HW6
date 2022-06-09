using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    public class Logger
    {
        public string[] Logs = new string[100];
        private static readonly Logger _instance = new Logger();
        
        static Logger() { }

        private Logger() { }
        public void Log(DateTime dateTime, LogType logType, string messege)
        {
            var fullMessege = $"{dateTime}: {logType}: {messege}";
            Console.WriteLine(fullMessege);
            int index = Array.IndexOf(Logs, null);
            Logs[index] = fullMessege;
        }

        public static Logger Instance
        {
            get { return _instance; }
        }
        public string[] GetLogs
        {
            get { return Logs; }
        }
    }
}
