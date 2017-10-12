using AnalysisLibrary.Accountability;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class AccountabilityTest
    {
        [TestMethod]
        public void Get_PartyByLegalId9508136364_ShouldReturnAUserWithMyName()
        {
            FakePartyRepository sut = new FakePartyRepository();

            sut.Get("9508136364").Name.Should().Be("Perly Gustafsson");
        }
    }
}
