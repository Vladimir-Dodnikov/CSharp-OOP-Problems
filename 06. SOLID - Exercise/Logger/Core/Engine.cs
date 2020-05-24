using Logger.Appenders;
using Logger.Enums;
using Logger.Factory;
using Logger.Layouts;
using Logger.Loggers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Core
{
    public class Engine
    {
        private readonly CommandInterpreter commandInterpreter;
        public Engine(CommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }
         
        public void Run()
        {
            string input = Console.ReadLine();

            while (true)
            {
                try
                {
                    string[] inputInfo = input.Split(" ");

                    if (input == "END")
                    {
                        commandInterpreter.Read(inputInfo);
                        break;
                    }
                    this.commandInterpreter.Read(inputInfo);

                    input = Console.ReadLine();
                }
                catch (Exception messageException)
                {
                    Console.WriteLine(messageException.Message);
                }
            }
        }
    }
}
