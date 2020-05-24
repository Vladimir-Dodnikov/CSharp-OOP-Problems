using Logger.Appenders;
using Logger.Core;
using Logger.Enums;
using Logger.Layouts;
using Logger.Loggers;
using System;

namespace Logger
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //First check
            //ILayout simpleLayout = new SimpleLayout();

            //IAppender consoleAppender = new ConsoleAppender(simpleLayout);

            //ILogger logger = new Loggs(consoleAppender);

            //logger.Error("3/26/2015 2:08:11 PM", "Error parsing JSON.");
            //logger.Info("3/26/2015 2:08:11 PM", "User Pesho successfully registered.");

            //Second check
            //var simpleLayout = new SimpleLayout();
            //var consoleAppender = new ConsoleAppender(simpleLayout);

            //var file = new LogFile();
            //var fileAppender = new FileAppender(simpleLayout, file);

            //var logger = new Loggs(consoleAppender, fileAppender);
            //logger.Error("3/26/2015 2:08:11 PM", "Error parsing JSON.");
            //logger.Info("3/26/2015 2:08:11 PM", "User Pesho successfully registered.");

            //Third check - Extensibility
            //var xmlLayout = new XmlLayout();
            //var consoleAppender = new ConsoleAppender(xmlLayout);
            //var logger = new Loggs(consoleAppender);

            //logger.Fatal("3/31/2015 5:23:54 PM", "mscorlib.dll does not respond");
            //logger.Critical("3/31/2015 5:23:54 PM", "No connection string found in App.config");

            //Fourth check - Report Threshold
            //var simpleLayout = new SimpleLayout();
            //var consoleAppender = new ConsoleAppender(simpleLayout);
            //consoleAppender.ReportLevel = ReportLevel.Error;

            //var logger = new Loggs(consoleAppender);

            //logger.Info("3/31/2015 5:33:07 PM", "Everything seems fine");
            //logger.Warning("3/31/2015 5:33:07 PM", "Warning: ping is too high - disconnect imminent");
            //logger.Error("3/31/2015 5:33:07 PM", "Error parsing request");
            //logger.Critical("3/31/2015 5:33:07 PM", "No connection string found in App.config");
            //logger.Fatal("3/31/2015 5:33:07 PM", "mscorlib.dll does not respond");

            //Fifth check - LogFile
            //var simpleLayout = new SimpleLayout();
            //var logFile = new LogFile();
            //var fileAppender = new FileAppender(simpleLayout, logFile);
            //fileAppender.ReportLevel = ReportLevel.Error;

            //var logger = new Loggs(fileAppender);
            //logger.Error("3/31/2015 5:33:07 PM", "Error parsing request");

            //Console.WriteLine(((FileAppender)fileAppender).LogFile.Size);


            //Final check - Command Interpreter
            CommandInterpreter commandInterpreter = new CommandInterpreter();
            Engine engine = new Engine(commandInterpreter);
            engine.Run();
        }
    }
}
