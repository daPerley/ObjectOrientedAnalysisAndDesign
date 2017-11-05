using System.Collections.Generic;

namespace BengansBowlinghallLibrary.FakeData
{
    public class FakeParties
    {
        public static readonly FakeParties _instance = new FakeParties();

        public List<Party> GetParties()
        {
            return new List<Party>
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
        }

        FakeParties() { }
    }
}
