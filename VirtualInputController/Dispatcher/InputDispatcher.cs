#region Namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualInputController.Common.Interfaces;
using VirtualInputController.NativeInput;
using NLog;

#endregion

namespace VirtualInputController.Dispatcher
{
    public class InputDispatcher : IInputDispatcher
    {
        private ILogger _logger;

        public InputDispatcher(ILogger logger)
        {
            _logger = logger;
        }

        public async Task<int> SendInputsAsync(params IInput[] inputs)
        {
            INPUT[] nativeInputs = ConvertInputsToNative(inputs);
            return await Task.Run(() => NativeInput.NativeInput.SendInputs(nativeInputs));
        }

        public static INPUT[] ConvertInputsToNative(IInput[] inputs)
        {
            throw new NotImplementedException();
        }
    }
}
