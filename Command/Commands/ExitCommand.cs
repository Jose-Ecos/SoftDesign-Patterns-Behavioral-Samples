namespace Command.Commands
{    
    using System;
    using System.IO;
    using Command.Commands.Base;

    public class ExitCommand : ICommand {

        public static readonly string COMMAND_NAME = "exit";

        public string GetCommandName() {
            return COMMAND_NAME;
        }

        public void Execute(string[] args, StreamWriter output) {
            Environment.Exit(0);
        }
    }
}

