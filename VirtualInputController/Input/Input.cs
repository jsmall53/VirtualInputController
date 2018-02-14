#region Namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VirtualInputController.NativeInput;

#endregion

namespace VirtualInputController.Input
{
    public class Input : IInput
    {
        private static INPUT _input;

        public int Value { get ; private set; }
        public bool IsPressed { get ; private set; }

        public Input(int value)
        {

        }

        public void Press()
        {
            throw new NotImplementedException();
        }

        public void Release()
        {
            throw new NotImplementedException();
        }

        private int SendInput()
        {
            return SendInput();
        }

    }
}
