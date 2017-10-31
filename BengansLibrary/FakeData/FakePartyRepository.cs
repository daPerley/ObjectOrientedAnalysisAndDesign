using System;
using System.Collections.Generic;
using System.Linq;

namespace BengansBowlinghallLibrary.FakeData
{
    public class FakePartyRepository : IPartyService
    {
        public List<Party> parties = new List<Party>
        {
            new Party {
                Id = 1,
                Name = "Duck",
                Email = "Duck@willwin.com",
                LegalId = "0909092345",
                Phone = "0707070700",
                IsMember = true

            },
            new Party {
                Id = 2,
                Name = "Chuck",
                Email = "Chuck@willnotwin.com",
                LegalId = "0909092345",
                Phone = "0707070700",
                IsMember = true

            },
            new Party {
                Id = 3,
                Name = "Lala",
                Email = "Lala@willnotwin.com",
                LegalId = "0909092345",
                Phone = "0707070700",
                IsMember = true

            },
             new Party {
                Id = 4,
                Name = "Luke",
                Email = "Luke@willnotwin.com",
                LegalId = "0909092345",
                Phone = "0707070700",
                IsMember = false

            },
             new Party {
                Id = 5,
                Name = "Ranger",
                Email = "Ranger@willnotwin.com",
                LegalId = "0909092345",
                Phone = "0707070700",
                IsMember = false

            }
        };

        public List<Game> games = new List<Game>
        {
            new Game
            {
                Id = 1,
                DateTime = new DateTime(2017,5,24)
            },
            new Game
            {
                Id = 2,
                DateTime = new DateTime(2017,2,22)
            },
            new Game
            {
                Id = 3,
                DateTime = new DateTime(2017,9,17)
            }
        };

        public List<GameParty> gameParties = new List<GameParty>
        {
            new GameParty
            {
                Id = 1,
                PartyId = 1,
                GameId = 1
            },
            new GameParty
            {
                Id = 2,
                PartyId = 3,
                GameId = 1
            },
            new GameParty
            {
                Id = 3,
                PartyId = 1,
                GameId = 2
            },
            new GameParty
            {
                Id = 4,
                PartyId = 3,
                GameId = 2
            },
            new GameParty
            {
                Id = 5,
                PartyId = 4,
                GameId = 3
            },
            new GameParty
            {
                Id = 6,
                PartyId = 5,
                GameId = 3
            },
            new GameParty
            {
                Id = 7,
                PartyId = 2,
                GameId = 3
            }
        };

        public List<Set> sets = new List<Set>
        {
            Set.RandomSet(1, 1, 1),
            Set.RandomSet(2, 1, 2),
            Set.RandomSet(3, 1, 3),
            Set.RandomSet(4, 2, 1),
            Set.RandomSet(5, 2, 2),
            Set.RandomSet(6, 2, 3),
            Set.RandomSet(7, 3, 1),
            Set.RandomSet(8, 3, 2),
            Set.RandomSet(9, 3, 3),
            Set.RandomSet(10, 4, 1),
            Set.RandomSet(11, 4, 2),
            Set.RandomSet(12, 4, 3),
            Set.RandomSet(13, 5, 1),
            Set.RandomSet(14, 5, 2),
            Set.RandomSet(15, 5, 3),
            Set.RandomSet(16, 6, 1),
            Set.RandomSet(17, 6, 2),
            Set.RandomSet(18, 6, 3),
            Set.RandomSet(19, 7, 1),
            Set.RandomSet(20, 7, 2),
            Set.RandomSet(21, 7, 3),
        };

        public Party GetChampion(string year)
        {
            List<Game> gamesOfYear = games.FindAll(games => games.DateTime.Year.ToString() == year);

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
            var gameParty = gameParties.FindAll(g => g.GameId == gameId);

            int leadingPartyId = 0;
            List<int> tiePartyIds = new List<int>();
            var leadingPoints = 0;

            foreach (var party in gameParty)
            {
                var points = 0;

                foreach (var set in sets.Where(s => s.GamePartyId == party.Id))
                {
                    foreach (var frame in set.Frames)
                    {
                        points += frame;
                    }
                }

                if (points > leadingPoints)
                {
                    leadingPartyId = party.PartyId;
                    leadingPoints = points;
                    tiePartyIds = new List<int>();
                }
                else if (points == leadingPoints)
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
                    winner.Add(parties.FirstOrDefault(p => p.Id == id));
                    // TODO: Return this list when there's more than one winner, or let the first to the points win as for now...
                }
            }

            return parties.FirstOrDefault(p => p.Id == leadingPartyId);
        }
    }
}
