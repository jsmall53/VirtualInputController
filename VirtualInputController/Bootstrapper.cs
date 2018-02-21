using Microsoft.Practices.Unity;
using Unity;
using NLog;
using VirtualInputController.Common;
using VirtualInputController.Common.Models.Factory;

namespace VirtualInputController
{
    public class Bootstrapper
    {
        public readonly UnityContainer container;
        //IoC stuff goes here

        public Bootstrapper()
        {
            container = new UnityContainer();
        }

        public void ConfigureContainer()
        {
            container.RegisterType<IInputFactory, InputFactory>();
        }
    }
}
