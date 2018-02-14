#region Namespaces
using Unity;
#endregion

namespace VirtualInputController.Registration
{
    public interface IRegistrationModule
    {
        void Register(UnityContainer container);
    }
}
