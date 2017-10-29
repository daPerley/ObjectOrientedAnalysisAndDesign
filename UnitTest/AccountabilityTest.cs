using AnalysisLibrary.Accountability;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class AccountabilityTest
    {
        public FakePartyRepository sut = new FakePartyRepository();

        [TestMethod]
        public void Get_PartyByLegalId9508136364_ShouldReturnAUserWithMyName()
        {
            sut.Get("9508136364").Name.Should().Be("Perly Gustafsson");
        }

        [TestMethod]
        public void Get_PartyByNonExistentLegalId_ShouldReturnInvalidOperationException()
        {
            Assert.ThrowsException<InvalidOperationException>(() => sut.Get("nonexistinglegalid"));
        }
    }
}
