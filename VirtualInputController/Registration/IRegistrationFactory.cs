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
    public interface IRegistrationFactory
    {
        void RegisterApplication(UnityContainer container);
    }
}
