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

namespace VirtualInputController.Dispatcher.Module
{
    public class InputDispatcherRegistrationModule : IRegistrationModule
    {
        public void Register(UnityContainer container)
        {
            container.RegisterType<IInputDispatcher, InputDispatcher>(new ContainerControlledLifetimeManager());
        }
    }
}
