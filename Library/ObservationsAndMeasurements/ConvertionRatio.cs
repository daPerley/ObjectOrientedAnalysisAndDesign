using System;

namespace AnalysisLibrary.ObservationsAndMeasurements
{
    class ConvertionRatio
    {
        public Guid Id { get; set; }
        public decimal Ratio { get; set; }

        public Guid FromUnitId { get; set; }
        public Unit FromUnit { get; set; }

        public Guid ToUnitId { get; set; }
        public Unit ToUnit { get; set; }
    }
}
