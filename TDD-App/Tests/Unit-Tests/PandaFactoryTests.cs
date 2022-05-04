using TDD_App;
using Xunit;
using FluentAssertions;
using System;

namespace Unit_Tests
{
    public class PandaFactoryTests
    {

        [Theory]
        [InlineData(0, "🐼 + 🐬 = 🔪🐳", "a panda dolphin is an orca")]
        [InlineData(1, "🐼 + 📖 = 📰", "a panda book is a newspaper")]
        [InlineData(2, "🐼 + 🐼 = 🐼", "a panda panda is a panda")]
        [InlineData(3, "🐼 + 🐼 + 🐼 + 🐼 = Broads in Atlanta", "a panda panda panda panda is a sick beat drop")]
        public void GivenAPandaFactory_WhenCreatingAPandaOfType_ThenVerifyTheExpectedResultIsReturned(int type, string expected, string reason)
        {
            //Arrange - your items to test
            var pf = new PandaFactory();

            //Act - perform your test action
            var pandapanda = pf.CreatePanda(type);

            pandapanda.Should().Be(expected, reason);
        }

        [Fact]
        public void GivenAPandaFactory_WhenCreatingAPandaOfType4_ThenVerifyAnInvalidOperationExceptionIsThrown()
        {
            //Arrange - your items to test
            var pf = new PandaFactory();
            const int pandaType = 5;

            //Act - perform your test action
            Action throwError = () => pf.CreatePanda(pandaType);

            throwError.Should().Throw<InvalidOperationException>("because I couldn't think of more panda types");
        }


    }
}