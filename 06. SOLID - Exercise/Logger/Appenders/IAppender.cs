using Logger.Enums;
using Logger.Layouts;

namespace Logger.Appenders
{
    public interface IAppender
    {
        public ILayout Layout { get; }
        public ReportLevel ReportLevel { get; set; }

        void Append(string dateTime, ReportLevel logLevel, string message);
    }
}
