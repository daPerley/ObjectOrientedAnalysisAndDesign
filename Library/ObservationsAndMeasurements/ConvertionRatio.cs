using System;

namespace AnalysisLibrary.ObservationsAndMeasurements
{
    public class ConvertionRatio
    {
        public int Id { get; set; }
        public decimal Ratio { get; set; }

        public int FromUnitId { get; set; }
        public Unit FromUnit { get; set; }

        public int ToUnitId { get; set; }
        public Unit ToUnit { get; set; }
    }
}
