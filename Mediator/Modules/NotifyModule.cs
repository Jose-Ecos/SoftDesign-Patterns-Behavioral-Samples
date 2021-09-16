namespace Mediator.Modules
{
    using System;
    using Mediator.Base;

    public class NotifyModule : AbstractModule
    {

        public static readonly string MODULE_NAME = "Notification";
        public const string OPERATION_NOTIFY = "Notify";

        public override string GetModulName()
        {
            return MODULE_NAME;
        }

        public override object NotifyMessage(ModuleMessage message)
        {
            switch (message.MessageType)
            {
                case OPERATION_NOTIFY:
                    return Notify(message);
                default:
                    throw new SystemException("Operation not supported '" + message.MessageType + "'");
            }
        }

        private object Notify(ModuleMessage message)
        {
            Console.WriteLine("Notification sent");
            return null;
        }
    }
}
