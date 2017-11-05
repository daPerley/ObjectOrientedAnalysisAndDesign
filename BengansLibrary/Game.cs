using System;

namespace BengansBowlinghallLibrary
{
    public class Game
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int LaneId { get; set; }
        public bool IsCompetition { get; set; }
        public string CompetitionName
        {
            get { return CompetitionName; }
            set
            {
                if (!IsCompetition)
                    CompetitionName = "Does not apply";
                else
                    CompetitionName = value;
            }
        }
    }
}
