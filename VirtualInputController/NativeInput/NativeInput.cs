using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace VirtualInputController.NativeInput
{
    class NativeInput
    {
        [DllImport("User32.dll")]
        public static extern UInt32 SendInput(UInt32 numInputs, INPUT[] inputs, Int32 size);
    }
}
