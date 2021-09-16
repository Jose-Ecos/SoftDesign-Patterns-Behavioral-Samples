namespace Mediator.Modules
{
    using System;
    using Mediator.Base;

    public class PurchaseModule : AbstractModule
    {

        public static readonly string MODULE_NAME = "Chopping";
        public const string OPERATION_PURCHASE_REQUEST = "PurchaseRequest";

        public override string GetModulName()
        {
            return MODULE_NAME;
        }

        public override object NotifyMessage(ModuleMessage message)
        {
            switch (message.MessageType)
            {
                case OPERATION_PURCHASE_REQUEST:
                    return PurchaseRequest(message);
                default:
                    throw new SystemException("Operation not supported '" + message.MessageType + "'");
            }
        }

        private object PurchaseRequest(ModuleMessage message)
        {
            return null;
        }
    }
}
