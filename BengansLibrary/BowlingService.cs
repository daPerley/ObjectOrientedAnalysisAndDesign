using BengansBowlinghallLibrary.FakeData;
using System.Collections.Generic;
using System.Linq;

namespace BengansBowlinghallLibrary
{
    public class BowlingService : IBowlingService
    {
        private FakeDBContext _fakeDBContext;

        private PartyRepositoryInMemory partyRepositoryInMemory = new PartyRepositoryInMemory();

        public BowlingService(FakeDBContext fakeDBContext)
        {
            _fakeDBContext = fakeDBContext;
        }

        public Party AddPartyIM(string name, bool isMember)
        {
            return partyRepositoryInMemory.AddParty(name, isMember);
        }

        public Party GetIM(int id)
        {
            return partyRepositoryInMemory.Get(id);
        }

        public Party GetChampion(string year)
        {
            List<Game> gamesOfYear = _fakeDBContext.Games.FindAll(games => games.DateTime.Year.ToString() == year);

            var winners = new List<Party>();

            foreach (var game in gamesOfYear)
            {
                winners.Add(GetWinner(game.Id));
            }

            var winner = winners.GroupBy(w => w).OrderByDescending(grp => grp.Count())
      .Select(grp => grp.Key).First();

            return winner;

            // TODO: Figure a better system than letting the player that is slumped to the first spot when several players have the same number of wins win
        }

        public Party GetWinner(int gameId)
        {
            var gameParty = _fakeDBContext.GameParties.FindAll(g => g.GameId == gameId);

            int leadingPartyId = 0;
            List<int> tiePartyIds = new List<int>();
            var leadingPoints = 0;

            foreach (var party in gameParty)
            {
                if (party.TotalScore > leadingPoints)
                {
                    leadingPartyId = party.PartyId;
                    leadingPoints = party.TotalScore;
                    tiePartyIds = new List<int>();
                }
                else if (party.TotalScore == leadingPoints)
                {
                    tiePartyIds.Add(leadingPartyId);
                    tiePartyIds.Add(party.PartyId);
                }
            }

            List<Party> winner = new List<Party>();

            if (tiePartyIds != null)
            {
                foreach (var id in tiePartyIds)
                {
                    winner.Add(_fakeDBContext.Parties.FirstOrDefault(p => p.Id == id));
                    // TODO: Return this list when there's more than one winner, or let the first to the points win as for now...
                }
            }

            return _fakeDBContext.Parties.FirstOrDefault(p => p.Id == leadingPartyId);
        }
    }
}
