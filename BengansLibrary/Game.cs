﻿using System;
using System.Collections.Generic;

namespace BengansBowlinghallLibrary
{
    public class Game
    {
        public int Id { get; set; }
        public IEnumerable<Party> Players { get; set; }
        public DateTime DateTime { get; set; }
    }
}
