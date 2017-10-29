using BengansBowlinghallLibrary.FakeData;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BengansBowlinghallTest
{
    [TestClass]
    public class PartyServiceTest
    {
        public FakePartyRepository sut = new FakePartyRepository();

        [TestMethod]
        public void GetWinner_GetWinnerByGameId_ShouldReturnAPlayer()
        {
            sut.GetWinner(1).Id.ShouldBeEquivalentTo(1);
        }
    }
}
