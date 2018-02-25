using Microsoft.Practices.Unity;
using Unity;
using Unity.Lifetime;
using NLog;
using VirtualInputController.Common;
using VirtualInputController.Factory;
using VirtualInputController.Dispatcher;
using VirtualInputController.Registration;

namespace VirtualInputController
{
    public class Bootstrapper
    {
        private static readonly UnityContainer container = new UnityContainer();
        //IoC stuff goes here

        public Bootstrapper()
        {
            Container = container;
        }

        public UnityContainer Container { get; private set; }

        private void BootstrapApplication()
        {
            RegistrationFactory.BootstrapApplication(container);
        }
    }
}
