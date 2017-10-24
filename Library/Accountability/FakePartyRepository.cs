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
            return parties.FirstOrDefault(x => x.LegalId == term);
        }
    }
}
