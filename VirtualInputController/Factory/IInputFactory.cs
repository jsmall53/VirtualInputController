#region Namespaces
using System;
using VirtualInputController.Common.Interfaces;
#endregion

namespace VirtualInputController.Factory
{
    public interface IInputFactory
    {
        IInput CreateInput(UInt16 keyValue);
    }
}
