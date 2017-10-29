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
        public void GetWinner_GetWinnerByGameId_ShouldReturnPartyWithId1()
        {
            sut.GetWinner(1).Id.ShouldBeEquivalentTo(1);
        }

        [TestMethod]
        public void GetChampion_GetChampionByYear_ShouldReturnPartyWithId1()
        {
            sut.GetChampion("2017").Id.ShouldBeEquivalentTo(1);
        }
    }
}
