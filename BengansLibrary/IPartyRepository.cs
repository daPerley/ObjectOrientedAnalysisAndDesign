using System;
using System.Collections.Generic;
using System.Text;

namespace BengansBowlinghallLibrary
{
    public interface IPartyRepository
    {
        Party Get(int id);
        Party AddParty(string name, bool isMember);
    }
}
