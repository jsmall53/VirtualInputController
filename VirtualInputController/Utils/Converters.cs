using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualInputController.Common.Interfaces;
using VirtualInputController.NativeInput;

namespace VirtualInputController.Utils
{
    class Converters
    {
        public static INPUT[] ConvertInputsToNative(List<IInput> inputs)
        {
            INPUT[] native = new INPUT[inputs.Count];
            int index = 0;

            foreach (IInput input in inputs)
            {
                INPUT newInput = new INPUT();
                newInput.Data.keyboard.ScanCode = input.Value;
                newInput.Data.keyboard.Flags = (input.IsPressed ? InputConstants.RELEASE_INPUT : InputConstants.PRESS_INPUT);
                native[index] = newInput;
                index++;
            }

            return native;
        }
    }
}
