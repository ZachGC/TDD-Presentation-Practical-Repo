using TDD_App;
using Xunit;
using FluentAssertions;
using System;

namespace Unit_Tests
{
    public class PandaFactoryTests
    {
        [Fact]
        public void GivenAPandaFactory_WhenCreatingAPandaOfType0_ThenVerifyAKillerWhaleIsReturned()
        {
            //Arrange - your items to test
            var pf = new PandaFactory();
            const int pandaType = 0;

            //Act - perform your test action
            var killerWhale = pf.CreatePanda(pandaType);

            //Assert - test that your output is what it should be
            killerWhale.Should().Be("🐼 + 🐬 = 🔪🐳", "a panda dolphin is an orca");
        }
        [Fact]
        public void GivenAPandaFactory_WhenCreatingAPandaOfType1_ThenVerifyANewspaperIsReturned()
        {
            //Arrange - your items to test
            var pf = new PandaFactory();
            const int pandaType = 1;

            //Act - perform your test action
            var newspaper = pf.CreatePanda(pandaType);

            //Assert - test that your output is what it should be
            newspaper.Should().Be("🐼 + 📖 = 📰", "a panda book is a newspaper");
        }
        [Fact]
        public void GivenAPandaFactory_WhenCreatingAPandaOfType2_ThenVerifyAPandaIsReturned()
        {
            //Arrange - your items to test
            var pf = new PandaFactory();
            const int pandaType = 2;

            //Act - perform your test action
            var panda = pf.CreatePanda(pandaType);

            //Assert - test that your output is what it should be
            panda.Should().Be("🐼 + 🐼 = 🐼", "a panda panda is a panda");
        }
        [Fact]
        public void GivenAPandaFactory_WhenCreatingAPandaOfType3_ThenVerifyASickBeatDropIsReturned()
        {
            //Arrange - your items to test
            var pf = new PandaFactory();
            const int pandaType = 3;

            //Act - perform your test action
            var pandapanda = pf.CreatePanda(pandaType);

            //Assert - test that your output is what it should be
            pandapanda.Should().Be("🐼 + 🐼 + 🐼 + 🐼 = Broads in Atlanta", "a panda panda panda panda is a sick beat drop");
        }

        [Fact]
        public void GivenAPandaFactory_WhenCreatingAPandaOfType4_ThenVerifyAnInvalidOperationExceptionIsThrown()
        {
            //Arrange - your items to test
            var pf = new PandaFactory();
            const int pandaType = 5;

            //Act - perform your test action
            Action throwError = () => pf.CreatePanda(pandaType);

            //Assert - test that your output is what it should be
            throwError.Should().Throw<InvalidOperationException>("because I couldn't think of more panda types");
        }
    }
}