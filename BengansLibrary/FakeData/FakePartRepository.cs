using System;
using System.Collections.Generic;

namespace BengansBowlinghallLibrary.FakeData
{
    public class FakePartRepository : IPartyService
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
            //Set up fake games
        };

        public List<GameParty> gameParties = new List<GameParty>
        {
            //Set up fake gamesparties
        };

        public Party GetChampion(string year)
        {
            throw new NotImplementedException();
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
                // Calculate the sets in a loop

                if (points > leadingPoints)
                {
                    leadingPartyId = party.PartyId;
                }
                else if (points == leadingPoints)
                {
                    tiePartyIds.Add(leadingPartyId);
                    tiePartyIds.Add(party.PartyId);
                }
            }

            var winner = new Party(); //replace with actual winner

            return winner;
        }
    }
}
