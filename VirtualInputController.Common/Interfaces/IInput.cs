#region Namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace VirtualInputController.Common.Interfaces
{
    public interface IInput
    {
        long ID { get; set; }
        UInt16 Value { get; }
        bool IsPressed { get; set; }
    }
}
