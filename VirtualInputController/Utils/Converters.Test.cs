#if DEBUG || TEST_BEHIND

// place using directives here to properly exclude the entire file based on #if directive
using System;
using System.Collections.Generic;
using Xunit;
using VirtualInputController.NativeInput;
using VirtualInputController.Common.Interfaces;
using VirtualInputController.Common.Models;
using VirtualInputController.Utils;

namespace Test.VirtualInputController.Utils
{
   public class ConvertersTests
   {
        public static List<IInput> CreateInputsList()
        {
            List<IInput> inputList = new List<IInput>();
            inputList.Add(new Input(69));
            inputList.Add(new Input(70));
            inputList.Add(new Input(71));

            return inputList;
        }

        [Fact]
        public void ConvertInputsToNativeNotNull()
        {
            var inputList = CreateInputsList();
            INPUT[] nativeInputs = Converters.ConvertInputsToNative(inputList);
            Assert.NotNull(nativeInputs);
        }
    }
}

#endif
