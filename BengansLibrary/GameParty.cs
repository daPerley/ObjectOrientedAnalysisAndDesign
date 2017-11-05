using System.Collections.Generic;

namespace BengansBowlinghallLibrary
{
    public class GameParty
    {
        public int Id { get; set; }
        public int PartyId { get; set; }
        public int GameId { get; set; }
        public int TotalScore { get; set; }

        public static int CalculateTotalScore(List<Set> sets)
        {
            var totalScore = 0;

            foreach (var set in sets)
            {
                foreach (var frame in set.Frames)
                {
                    totalScore += frame;
                }
            }

            return totalScore;
        }
    }
}
