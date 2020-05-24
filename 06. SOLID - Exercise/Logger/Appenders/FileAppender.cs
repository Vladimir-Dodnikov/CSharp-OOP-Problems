using Logger.Enums;
using Logger.Layouts;
using Logger.Loggers;

namespace Logger.Appenders
{
    public class FileAppender : Appender
    {
        public FileAppender(ILayout layout, ILogFile logFile)
            : base(layout)
        {
            this.LogFile = logFile;
        }
        public ILogFile LogFile { get; }

        public override void Append(string dateTime, ReportLevel logLevel, string message)
        {
            if (logLevel >= this.ReportLevel)
            {
                this.Counter++;
                this.LogFile.Write(string.Format(this.Layout.Format, dateTime, logLevel, message));
            }
        }
        public override string ToString()
        {
            return base.ToString() + $", File size: {this.LogFile.Size}";
        }
    }
}
