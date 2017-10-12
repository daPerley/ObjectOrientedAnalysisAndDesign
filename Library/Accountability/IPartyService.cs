using System;
using System.Collections.Generic;
using System.Text;

namespace AnalysisLibrary.Accountability
{
    public interface IPartyService
    {
        Party Get(string term);
    }
}
