using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalysisLibrary.ObservationsAndMeasurements;
using FluentAssertions;

namespace AnalysisTest
{
    [TestClass]
    public class ObservationsAndMeasurmentsTest
    {
        public static Unit unitOne = new Unit()
        {
            Id = 1,
            Name = "Sek"
        };

        public static Unit unitTwo = new Unit()
        {
            Id = 2,
            Name = "USD"
        };

        public static ConvertionRatio convertionRatio = new ConvertionRatio()
        {
            Id = 1,
            FromUnit = unitTwo,
            FromUnitId = 2,
            ToUnit = unitOne,
            ToUnitId = 1,
            Ratio = 8.1m
        };

        public static Quantity chocolateCost = new Quantity() {
            Id = 1,
            Amount = 10,
            Unit = unitTwo,
            UnitId = 2
        };

        [TestMethod]
        public void Convert_ConvertChocolateCostFromUSDToSEK_ShouldReturnEightyOne()
        {
            Quantity.ConvertQuantity(convertionRatio, chocolateCost).Amount.Should().Be(81m);
        }
    }
}
