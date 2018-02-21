using Microsoft.Practices.Unity;
using Unity;
using Unity.Lifetime;
using NLog;
using VirtualInputController.Common;
using VirtualInputController.Factory;
using VirtualInputController.Dispatcher;

namespace VirtualInputController
{
    public class Bootstrapper
    {
        public readonly UnityContainer container;
        //IoC stuff goes here

        public Bootstrapper()
        {
            container = new UnityContainer();
            ConfigureContainer();
        }

        public void ConfigureContainer()
        {
            container.RegisterType<IInputFactory, InputFactory>(new ContainerControlledLifetimeManager());
            container.RegisterType<IInputDispatcher, InputDispatcher>(new ContainerControlledLifetimeManager());
        }
    }
}
