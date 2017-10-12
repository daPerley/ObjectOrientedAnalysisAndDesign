using System;
using System.Collections.Generic;
using System.Linq;

namespace AnalysisLibrary.Accountability
{
    public class FakePartyRepository : IPartyService
    {
        public List<Party> parties = new List<Party>
        {
            new Party
            {
                Id = 1,
                Name = "Perly Gustafsson",
                LegalId = "9508136364"
            },
            new Party
            {
                Id = 2,
                Name = "Emil Ekman",
                LegalId = "9206242993"
            }
        };

        public Party Get(string term)
        {
            Party party = parties.FirstOrDefault(x => x.LegalId == term);

            if (party == null)
                throw new InvalidOperationException("No party with the give legal id could be found!");

            return party;
        }
    }
}
