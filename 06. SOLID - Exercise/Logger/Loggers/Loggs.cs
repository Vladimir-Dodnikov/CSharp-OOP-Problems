using Logger.Appenders;
using Logger.Enums;
using System;

namespace Logger.Loggers
{
    public class Loggs : ILogger
    {
        private IAppender[] appenders;
        public Loggs(params IAppender[] appenders)
        {
            this.Appenders = appenders;
        }

        public IAppender[] Appenders 
        {
            get
            {
                return this.appenders;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(Appenders), "value cannot be null");
                }
                this.appenders = value;
            }
        }
        public void Info(string dateTime, string message)
        {
            Append(dateTime, ReportLevel.Info, message);
        }
        public void Warning(string dateTime, string message)
        {
            Append(dateTime, ReportLevel.Warning, message);
        }
        public void Error(string dateTime, string message)
        {
            Append(dateTime, ReportLevel.Error, message);
        }
        public void Critical(string dateTime, string message)
        {
            Append(dateTime, ReportLevel.Critical, message);
        }
        public void Fatal(string dateTime, string message)
        {
            Append(dateTime, ReportLevel.Fatal, message);
        }

        private void Append(string dateTime, ReportLevel level, string message)
        {
            foreach (var appender in this.Appenders)
            {
                appender.Append(dateTime, level, message);
            }
        }
    }
}
