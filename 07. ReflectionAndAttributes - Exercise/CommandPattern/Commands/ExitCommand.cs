namespace CommandPattern.Commands
{
    using CommandPattern.Core.Contracts;
    using System;

    public class ExitCommand : ICommand
    {
        public string Execute(string[] args)
        {
            //stop directly from here the program
            Environment.Exit(0);
            return null;
        }
    }
}
