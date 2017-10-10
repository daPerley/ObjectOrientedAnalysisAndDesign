using System;

namespace AnalysisLibrary.ObservationsAndMeasurements
{
    class Quantity
    {
        public Guid Id { get; set; }
        public Decimal Amount { get; set; }

        public Guid UnitId { get; set; }
        public Unit Unit { get; set; }
    }
}
