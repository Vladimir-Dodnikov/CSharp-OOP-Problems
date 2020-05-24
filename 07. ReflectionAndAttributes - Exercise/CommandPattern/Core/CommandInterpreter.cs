namespace CommandPattern.Core
{
    using CommandPattern.Commands;
    using CommandPattern.Core.Contracts;
    using System;
    using System.Linq;
    using System.Reflection;

    public class CommandInterpreter : ICommandInterpreter
    {
        private const string COMMAND_POSTFIX = "Command";

        public string Read(string args)
        {
            string[] inputArgs = args
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string commandName = inputArgs[0] + COMMAND_POSTFIX;
            string[] commandArgs = inputArgs.Skip(1).ToArray();

            //return all metaInfo about this project - CommandPattern
            //if you use .GetExecutingAssembly -> Judge 0/100
            Assembly assembly = Assembly.GetCallingAssembly();

            //return all types class (or interface)
            Type[] type = assembly.GetTypes();

            //select spesific from above collection
            Type typeToCreate = type.FirstOrDefault(t => t.Name == commandName);

            //check type.IsNull
            if (typeToCreate == null)
            {
                throw new InvalidOperationException("Invalid Command Type!");
            }

            //create instance of given type
            Object instance = Activator.CreateInstance(typeToCreate);
            
            //convert obj to ICommand and abstract creation with Reflection
            ICommand command = (ICommand)instance;

            //call method
            string result = command.Execute(commandArgs);

            return result;

            //before Reflection

            //string[] commandArgs = inputArgs.Skip(1).ToArray();
            //string commandName = inputArgs[0];
            //if (command == "Hello")
            //{
            //    command = new HelloCommand();
            //}
            //else if (command == "Exit")
            //{
            //    command = new ExitCommand();
            //}
            //result = command.Execute();
            //else
            //{
            //    throw new InvalidOperationException("Invalid Command Type!");
            //}

        }
    }
}
