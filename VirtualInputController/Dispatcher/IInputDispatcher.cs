#region Namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VirtualInputController.Common.Interfaces;

#endregion

namespace VirtualInputController.Dispatcher
{
    public interface IInputDispatcher
    {
        Task<int> SendInputsAsync(List<IInput> inputs);
    }
}
