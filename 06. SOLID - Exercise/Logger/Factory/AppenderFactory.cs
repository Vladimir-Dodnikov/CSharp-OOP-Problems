using Logger.Appenders;
using Logger.Enums;
using Logger.Layouts;
using Logger.Loggers;
using System;

namespace Logger.Factory
{
    public static class AppenderFactory
    {
        public static IAppender CreateAppender(string type, ILayout layout, ReportLevel reportLevel)
        {
            switch (type)
            {
                case "ConsoleAppender":
                    return new ConsoleAppender(layout) { ReportLevel = reportLevel };
                case "FileAppender":
                    return new FileAppender(layout, new LogFile()) { ReportLevel = reportLevel};
                default:
                    throw new ArgumentException("Invalid Appender Type!");
            }
        }
    }
}
