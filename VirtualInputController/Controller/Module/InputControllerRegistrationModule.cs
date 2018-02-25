#region Namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;
using VirtualInputController.Registration;
using VirtualInputController.Controller.Repository;
#endregion

namespace VirtualInputController.Controller.Module
{
    public class InputControllerRegistrationModule : IRegistrationModule
    {
        public void Register(UnityContainer container)
        {
            container.RegisterType<IInputController, InputController>(new ContainerControlledLifetimeManager());
            container.RegisterType<IInputRepository, InputRepository>(new ContainerControlledLifetimeManager());
        }
    }
}
