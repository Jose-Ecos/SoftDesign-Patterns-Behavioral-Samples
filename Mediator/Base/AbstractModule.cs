namespace Mediator.Base
{
    using System;

    public abstract class AbstractModule
    {
        protected ModuleMediator Mediator;

        public abstract string GetModulName();

        public void Activate()
        {
            Mediator = ModuleMediator.getInstance();
            Mediator.RegistModule(this);
        }

        public abstract object NotifyMessage(ModuleMessage message);
    }
}
