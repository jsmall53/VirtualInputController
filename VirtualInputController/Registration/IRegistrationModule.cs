#region Namespaces
using Unity;
using Unity.Lifetime;
#endregion

namespace VirtualInputController.Registration
{
    public interface IRegistrationModule
    {
        void Register(UnityContainer container);
    }
}
