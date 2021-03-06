namespace Command.Commands
{
    using System.IO;

    public class EchoCommand : BaseCommand {

        public static readonly string COMMAN_NAME = "echo";

        public override void Execute(string[] args, StreamWriter output) {
            string message = GetCommandName() + " " + string.Join(" ", args);
            Write(output, message);
        }

        public override string GetCommandName() {
            return COMMAN_NAME;
        }
    }
}



