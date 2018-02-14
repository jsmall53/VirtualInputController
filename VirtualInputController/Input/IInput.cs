#region Namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace VirtualInputController.Input
{
    public interface IInput
    {
        void Press();
        void Release();

        int Value { get; }
        bool IsPressed { get; }
    }
}
