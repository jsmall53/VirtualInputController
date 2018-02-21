#region Namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualInputController.Common.Interfaces;
using VirtualInputController.Common.Models;
#endregion

namespace VirtualInputController.Factory
{
    public class InputFactory : IInputFactory
    {
        public IInput CreateInput(ushort keyValue)
        {
            return new Input();
        }
    }
}
