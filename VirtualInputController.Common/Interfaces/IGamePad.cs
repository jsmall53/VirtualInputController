#region Namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace VirtualInputController.Interfaces
{
    public interface IGamePad
    {
        List<int> Inputs { get; set; }
    }
}
