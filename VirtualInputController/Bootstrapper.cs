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

        public Bootstrapper()
        {
            BootstrapApplication();
        }

        public static UnityContainer Container { get => container; }

        private void BootstrapApplication()
        {
            RegistrationFactory.BootstrapApplication(container);
        }
    }
}
