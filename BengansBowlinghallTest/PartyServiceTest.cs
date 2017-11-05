using BengansBowlinghallLibrary;
using BengansBowlinghallLibrary.FakeData;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BengansBowlinghallTest
{
    [TestClass]
    public class PartyServiceTest
    {
        public PartyRepository sut = new PartyRepository(FakeParties._instance.GetParties(), FakeGames._instance.GetGames(), FakeGameParties._instance.GetGameParties());

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
