namespace Logger.Appenders
{
    using System;
    using Logger.Enums;
    using Logger.Layouts;

    class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout)
            : base(layout)
        {
        }
        public override void Append(string dateTime, ReportLevel logLevel, string message)
        {
            
            if (logLevel >= this.ReportLevel)
            {
                this.Counter++;
                Console.WriteLine(this.Layout.Format, dateTime, logLevel, message);
            }
        }
    }
}
