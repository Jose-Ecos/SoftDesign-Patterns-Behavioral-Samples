namespace Command.Commands
{    
    using System;
    using System.IO;
    using Command.Commands.Base;

    public abstract class BaseCommand : ICommand {

        public abstract string GetCommandName();

        public abstract void Execute(string[] args, StreamWriter output);

        public void Write(StreamWriter output, string message) {
            try {
                output.Write(message);
                output.Flush();
            } catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
        }
    }
}


