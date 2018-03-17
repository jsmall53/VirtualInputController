#region Namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualInputController.Common.Interfaces;
#endregion

namespace VirtualInputController.Common.Models
{
    public class Input : IInput
    {
        private ushort _value;

        public ushort Value => _value;
        public long ID { get; set; }
        public bool IsPressed { get; set; }
        

        public Input(ushort value)
        {
            _value = value;
            IsPressed = false;
        }

        

        
    }
}
