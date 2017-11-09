using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BengansBowlinghallLibrary
{
    public class PartyRepositoryInMemory : IPartyRepository
    {
        public List<Party> Parties = new List<Party>
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

        public Party AddParty(string name, bool isMember)
        {
            Party newParty = new Party()
            {
                Id = Parties.Count() +1,
                Name = name,
                IsMember = isMember
            };

            Parties.Add(newParty);

            return newParty;
        }

        public Party Get(int id)
        {
            return Parties.FirstOrDefault(p => p.Id == id);
        }
    }
}
