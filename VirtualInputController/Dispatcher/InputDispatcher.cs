#region Namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualInputController.Common.Interfaces;
using VirtualInputController.NativeInput;
using VirtualInputController.Factory;
using NLog;
#endregion

namespace VirtualInputController.Dispatcher
{
    public class InputDispatcher : IInputDispatcher
    {
        public InputDispatcher()
        {

        }

        public async Task<int> SendInputsAsync(List<IInput> inputs)
        {
            if (inputs == null)
            {
                return 0;
            }

            INPUT[] nativeInputs;

            try
            {
                nativeInputs = ConvertInputsToNative(inputs);
            } catch (NullReferenceException ex)
            {
                nativeInputs = null;
                ex.ToString();
            }

            return await Task.Run(() => NativeInput.NativeInput.SendInputs(nativeInputs));
        }

        public static INPUT[] ConvertInputsToNative(List<IInput> inputs)
        {
            INPUT[] native = new INPUT[inputs.Count];
            int index = 0;

            foreach(IInput input in inputs)
            {
                INPUT newInput = new INPUT();
                newInput.Data.keyboard.ScanCode = input.Value;
                native[index] = newInput;
                index++;
            }

            return native;
        }
    }
}
