#region Namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace VirtualInputController.Dispatcher
{
    public interface IInputDispatcher
    {
        bool SendOneOrMoreInputs(params long[] inputs);
    }
}
