#if DEBUG || TEST_BEHIND

// place using directives here to properly exclude the entire file based on #if directive
using System;
using Xunit;
using VirtualInputController.Factory;

namespace Test.VirtualInputController.FactoryTests
{
   public class InputFactoryTests : IClassFixture<InputFactoryFixture>
   {
        private IInputFactory _inputFactory;

        public InputFactoryTests(InputFactoryFixture inputFactoryFixture)
        {
            _inputFactory = inputFactoryFixture.InputFactory;
        }

        [Fact]
        public void VerifyFactory()
        {
            Assert.NotNull(_inputFactory);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void CreateInput(ushort inputValue)
        {
            var input = _inputFactory.CreateInput(inputValue);
            Assert.NotNull(input);
            Assert.Equal(inputValue, input.Value);
        }
    }

    public class InputFactoryFixture : IDisposable
    {
        public InputFactoryFixture()
        {
            InputFactory = new InputFactory();
        }

        public void Dispose()
        {

        }

        public InputFactory InputFactory { get; private set; }
    }

}

#endif
