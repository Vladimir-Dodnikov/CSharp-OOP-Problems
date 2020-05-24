using System;
using System.IO;
using System.Linq;

namespace Logger.Loggers
{
    public class LogFile : ILogFile
    {
        private const string logFilePath = "../../../log.txt";

        public int Size
            => File.ReadAllText(logFilePath).Where(c=>char.IsLetter(c)).Sum(x=>x);

        public void Write(string message)
        {
            File.AppendAllText(logFilePath, message + Environment.NewLine);
        }
    }
}
