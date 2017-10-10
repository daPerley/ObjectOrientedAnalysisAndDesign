using System;

namespace AnalysisLibrary.ObservationsAndMeasurements
{
    public class Quantity
    {
        public int Id { get; set; }
        public Decimal Amount { get; set; }

        public int UnitId { get; set; }
        public Unit Unit { get; set; }


        public static Quantity ConvertQuantity(ConvertionRatio convertionRatio, Quantity quantity)
        {
            // When using database replace convertionRatio above with the ratio the user wish to convert to
            // then search for the ConvertionRatio that goes from quantity.Unit to whishUnit

            quantity.Amount = quantity.Amount * convertionRatio.Ratio;
            quantity.Unit = convertionRatio.ToUnit;
            quantity.UnitId = convertionRatio.ToUnitId;

            return quantity;
        }
    }
}
