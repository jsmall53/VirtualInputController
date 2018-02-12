using System;
using System.Collections.Generic;
using Xunit;
using VirtualInputController.NativeInput;

namespace VirtualInputController.Test.NativeInputTests
{
    public class NativeInputTests
    {
        [Fact]
        public void SendZeroInputs()
        {
            List<INPUT> inputs = new List<INPUT>();
            int successfulInputs;
            
            successfulInputs = NativeInput.NativeInput.SendInput(inputs.ToArray());
            Assert.Equal(0, successfulInputs);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void SendNInputs(int numInputs)
        {
            int successfulInputs;
            INPUT testInput = new INPUT();
            List<INPUT> inputs = new List<INPUT>();

            testInput.type = 1;
            testInput.Data.keyboard.ScanCode = 203;
            testInput.Data.keyboard.VirtualKey = 0;
            testInput.Data.keyboard.Time = 0;
            testInput.Data.keyboard.ExtraInfo = IntPtr.Zero;

            inputs.Clear();
            for (int i = 0; i < numInputs; i++)
            {
                inputs.Add(testInput);    
            }
            successfulInputs = NativeInput.NativeInput.SendInput(inputs.ToArray());
            Assert.Equal(numInputs, successfulInputs);
        }
    }
}
