using System;
using System.Collections.Generic;

namespace BengansBowlinghallLibrary.FakeData
{
    public class FakeGames
    {
        public static readonly FakeGames _instance = new FakeGames();

        public List<Game> Get()
        {
            return new List<Game>
        {
            new Game
            {
                Id = 1,
                DateTime = new DateTime(2017,5,24),
                LaneId = 1,
                IsCompetition = false
            },
            new Game
            {
                Id = 2,
                DateTime = new DateTime(2017,2,22),
                LaneId = 2,
                IsCompetition = false
            },
            new Game
            {
                Id = 3,
                DateTime = new DateTime(2017,9,17),
                LaneId = 3,
                IsCompetition = false
            }
        };
        }

        FakeGames() { }
    }
}
