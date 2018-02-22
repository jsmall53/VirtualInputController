#if DEBUG || TEST_BEHIND

// place using directives here to properly exclude the entire file based on #if directive
using Xunit;
using System;
using System.Collections.Generic;
using VirtualInputController.Dispatcher;
using VirtualInputController.Common.Interfaces;
using VirtualInputController.Common.Models;
using VirtualInputController.NativeInput;

namespace Test.VirtualInputController.DispatcherTests
{
   public class InputDispatcherTests : IClassFixture<InputDispatcherFixture>
   {
        private InputDispatcherFixture fixture;

        public InputDispatcherTests(InputDispatcherFixture inputdispatcher)
        {
            fixture = inputdispatcher;
        }

        [Fact]
        public void ConvertInputsToNativeNotNull()
        {
            INPUT[] nativeInputs = InputDispatcher.ConvertInputsToNative(fixture.InputList);
            Assert.NotNull(nativeInputs);
        }

        [Fact]
        public void ConvertInputsToNativeNotEmpty()
        {
            INPUT[] nativeInputs = InputDispatcher.ConvertInputsToNative(fixture.InputList);
            Assert.NotEmpty(nativeInputs);
        }

        [Fact]
        public void ConvertInputsToNativeValues()
        {
            INPUT[] nativeInputs = InputDispatcher.ConvertInputsToNative(fixture.InputList);
            Assert.Equal(fixture.InputList[0].Value, nativeInputs[0].Data.keyboard.ScanCode);
            Assert.Equal(fixture.InputList[1].Value, nativeInputs[1].Data.keyboard.ScanCode);
            Assert.Equal(fixture.InputList[2].Value, nativeInputs[2].Data.keyboard.ScanCode);
        }

        [Fact]
        public void SendInputsAsyncNullList()
        {
            var result = fixture.InputDispatcher.SendInputsAsync(null);
            result.GetAwaiter().OnCompleted(() =>
            {
                var numInputsSent = result.GetAwaiter().GetResult();
                Assert.Equal(0, numInputsSent);
            });
        }

        [Fact]
        public void SendInputsAsyncEmptyList()
        {
            var result = fixture.InputDispatcher.SendInputsAsync(new List<IInput>());
            result.GetAwaiter().OnCompleted(() =>
            {
                var numInputsSent = result.GetAwaiter().GetResult();
                Assert.Equal(0, numInputsSent);
            });
        }

        [Fact]
        public void SendInputsAsyncTest()
        {
            var result = fixture.InputDispatcher.SendInputsAsync(fixture.InputList);
            result.GetAwaiter().OnCompleted(() => 
            {
                var numInputsSent = result.GetAwaiter().GetResult();
                Assert.Equal(fixture.InputList.Count, numInputsSent);
            });
        }
    }

    public class InputDispatcherFixture : IDisposable
    {
        
        public InputDispatcherFixture()
        {
            InputDispatcher = new InputDispatcher();
            CreateInputList();
        }

        public InputDispatcher InputDispatcher { get; set; }
        public List<IInput> InputList { get; set; }

        public void Dispose()
        {

        }

        private void CreateInputList()
        {
            InputList = new List<IInput>();
            InputList.Add(new Input(69));
            InputList.Add(new Input(70));
            InputList.Add(new Input(71));
        }
    }
}

#endif
