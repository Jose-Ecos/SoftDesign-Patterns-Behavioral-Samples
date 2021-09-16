namespace Mediator.Base
{
    public class ModuleMessage
    {
        public string Source { get; set; }
        public string Target { get; set; }
        public string MessageType { get; set; }
        public object Payload { get; set; }

        public ModuleMessage(string Source, string Target, string MessageType, object Payload)
        {
            this.Source = Source;
            this.Target = Target;
            this.MessageType = MessageType;
            this.Payload = Payload;
        }
    }
}
