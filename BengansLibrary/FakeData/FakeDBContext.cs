using System.Collections.Generic;

namespace BengansBowlinghallLibrary.FakeData
{
    public class FakeDBContext
    {
        public static readonly FakeDBContext _instance = new FakeDBContext();

        public List<Party> Parties = FakeParties._instance.Get();
        public List<Game> Games = FakeGames._instance.Get();
        public List<GameParty> GameParties = FakeGameParties._instance.Get();

        FakeDBContext() { }
    }
}
