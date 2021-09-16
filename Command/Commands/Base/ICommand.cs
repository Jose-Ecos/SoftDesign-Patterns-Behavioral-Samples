namespace Command.Commands.Base
{
    using System.IO;

    public interface ICommand
    {
        string GetCommandName();
        void Execute(string[] args, StreamWriter output);
    }
}
