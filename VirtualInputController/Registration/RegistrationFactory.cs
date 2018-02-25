#region Namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
#endregion

namespace VirtualInputController.Registration
{
    public class RegistrationFactory : IRegistrationFactory
    {
        public static void BootstrapApplication(UnityContainer container)
        {
            new RegistrationFactory().RegisterApplication(container);
        }

        /// <summary>
        /// Finds all the IRegistration modules and registers them
        /// </summary>
        /// <param name="container"></param>
        public void RegisterApplication(UnityContainer container)
        {
            var moduleType = typeof(IRegistrationModule);

            var types = AppDomain.CurrentDomain.GetAssemblies()
                        .SelectMany(s => s.GetTypes())
                        .Where(p => moduleType.IsAssignableFrom(p) && !p.IsInterface);

            List<IRegistrationModule> list = new List<IRegistrationModule>();

            foreach (var type in types)
            {
                IRegistrationModule module = Create(type);
                list.Add(module);
            }

            list.ForEach(m => m.Register(container));
        }

        private IRegistrationModule Create(Type type)
        {
            var item = Activator.CreateInstance(type);

            return (IRegistrationModule)item;
        }
    }
}
