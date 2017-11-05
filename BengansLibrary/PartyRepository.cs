using System.Collections.Generic;
using System.Linq;

namespace BengansBowlinghallLibrary
{
    public class PartyRepository : IPartyService
    {
        private List<Party> _parties;
        private List<Game> _games;
        private List<GameParty> _gameParties;

        public PartyRepository(List<Party> parties, List<Game> games, List<GameParty> gameParties)
        {
            _parties = parties;
            _games = games;
            _gameParties = gameParties;
        }

        public Party GetChampion(string year)
        {
            List<Game> gamesOfYear = _games.FindAll(games => games.DateTime.Year.ToString() == year);

            var winners = new List<Party>();

            foreach (var game in gamesOfYear)
            {
                winners.Add(GetWinner(game.Id));
            }

            var winner = winners.GroupBy(w => w).OrderByDescending(grp => grp.Count())
      .Select(grp => grp.Key).First();

            return winner;

            // Figure how to return more than one champion
        }

        public Party GetWinner(int gameId)
        {
            var gameParty = _gameParties.FindAll(g => g.GameId == gameId);

            int leadingPartyId = 0;
            List<int> tiePartyIds = new List<int>();
            var leadingPoints = 0;

            foreach (var party in gameParty)
            {
                if (party.TotalScore > leadingPoints)
                {
                    leadingPartyId = party.PartyId;
                    leadingPoints = party.TotalScore;
                }
                else if (party.TotalScore == leadingPoints)
                {
                    tiePartyIds.Add(leadingPartyId);
                    tiePartyIds.Add(party.PartyId);
                }
            }

            return _parties.FirstOrDefault(p => p.Id == leadingPartyId);

            // Figure how to return more than one winner
        }
    }
}
