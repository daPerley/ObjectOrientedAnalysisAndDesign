using System.Collections.Generic;
using System.Linq;

namespace BengansBowlinghallLibrary.FakeData
{
    public class FakeGameParties
    {
        public static readonly FakeGameParties _instance = new FakeGameParties();

        public List<GameParty> GetGameParties()
        {
            return new List<GameParty>
        {
            new GameParty
            {
                Id = 1,
                PartyId = 1,
                GameId = 1,
                TotalScore = GameParty.CalculateTotalScore(FakeSets._instance.GetSets().Where(s => s.GamePartyId == 1).ToList())
            },
            new GameParty
            {
                Id = 2,
                PartyId = 3,
                GameId = 1,
                TotalScore = GameParty.CalculateTotalScore(FakeSets._instance.GetSets().Where(s => s.GamePartyId == 2).ToList())
            },
            new GameParty
            {
                Id = 3,
                PartyId = 1,
                GameId = 2,
                TotalScore = GameParty.CalculateTotalScore(FakeSets._instance.GetSets().Where(s => s.GamePartyId == 3).ToList())
            },
            new GameParty
            {
                Id = 4,
                PartyId = 3,
                GameId = 2,
                TotalScore = GameParty.CalculateTotalScore(FakeSets._instance.GetSets().Where(s => s.GamePartyId == 4).ToList())
            },
            new GameParty
            {
                Id = 5,
                PartyId = 4,
                GameId = 3,
                TotalScore = GameParty.CalculateTotalScore(FakeSets._instance.GetSets().Where(s => s.GamePartyId == 5).ToList())
            },
            new GameParty
            {
                Id = 6,
                PartyId = 5,
                GameId = 3,
                TotalScore = GameParty.CalculateTotalScore(FakeSets._instance.GetSets().Where(s => s.GamePartyId == 6).ToList())
            },
            new GameParty
            {
                Id = 7,
                PartyId = 2,
                GameId = 3,
                TotalScore = GameParty.CalculateTotalScore(FakeSets._instance.GetSets().Where(s => s.GamePartyId == 7).ToList())
            }
        };
        }

        FakeGameParties() { }
    }
}
