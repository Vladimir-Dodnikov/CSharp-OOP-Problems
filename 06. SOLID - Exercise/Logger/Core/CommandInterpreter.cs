using Logger.Appenders;
using Logger.Enums;
using Logger.Factory;
using Logger.Layouts;
using Logger.Loggers;
using System;
using System.Collections.Generic;

namespace Logger.Core
{
    public class CommandInterpreter
    {
        List<IAppender> appenders;
        private ILogger logger;
        public CommandInterpreter()
        {
            this.appenders = new List<IAppender>();
        }

        //TODO: Should return string
        //For example: Succesfully created Appender
        //NOTE: This class is not implemented correctly
        public void Read(string[] args)
        {
            string command = args[0];

            if (command == "Create")
            {
                CreatAppender(args);
            }
            else if (command == "Append")
            {
                logger = new Loggs(appenders.ToArray());
                AppendMessage(args);
            }
            else if (command == "END")
            {
                PrintInfo();
            }
        }
        private void PrintInfo()
        {
            Console.WriteLine("Logger info");

            foreach (var appender in appenders)
            {
                Console.WriteLine(appender);
            }
        }
        private void CreatAppender(string[] inputInfo)
        {
            string appenderType = inputInfo[1];
            string layoutType = inputInfo[2];
            ReportLevel reportLevel = ReportLevel.Info;

            if (inputInfo.Length > 3)
            {
                reportLevel = Enum.Parse<ReportLevel>(inputInfo[3], true);
            }

            ILayout layout = LayoutFactory.CreateLayout(layoutType);
            IAppender appender = AppenderFactory.CreateAppender(appenderType, layout, reportLevel);
            appenders.Add(appender);
        }
        private void AppendMessage(string[] inputInfo)
        {
            string loggerMethodType = inputInfo[1];
            string date = inputInfo[2];
            string message = inputInfo[3];

            if (loggerMethodType == "INFO")
            {
                logger.Info(date, message);
            }
            else if (loggerMethodType == "ERROR")
            {
                logger.Error(date, message);
            }
            else if (loggerMethodType == "WARNING")
            {
                logger.Warning(date, message);
            }
            else if (loggerMethodType == "CRITICAL")
            {
                logger.Critical(date, message);
            }
            else if (loggerMethodType == "FATAL")
            {
                logger.Fatal(date, message);
            }
        }
    }
}
