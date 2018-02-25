#region Namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;
using VirtualInputController.Registration;
#endregion

namespace VirtualInputController.Factory.Module
{
    public class InputFactoryRegistrationModule : IRegistrationModule
    {
        public void Register(UnityContainer container)
        {
            container.RegisterType<IInputFactory, InputFactory>(new ContainerControlledLifetimeManager());
        }
    }
}
