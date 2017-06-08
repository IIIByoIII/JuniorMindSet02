using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaxiFare
{
    [TestClass]
    public class TaxiFareTests
    {
        [TestMethod]
        public void DaytimeFareForShortDistances()
        {
            Assert.AreEqual(5, CalculateTaxiFare(1, 8));
        }

        [TestMethod]
        public void DaytimeFareForMediumDistances()
        {
            Assert.AreEqual(168, CalculateTaxiFare(21, 8));
        }

        [TestMethod]
        public void DaytimeFareForLongDistances()
        {
            Assert.AreEqual(600, CalculateTaxiFare(100, 8));
        }

        decimal CalculateTaxiFare (int distanceInKm, int hour)
        {
            decimal[] daytimePrices = { 5, 8, 6 };
            decimal pricePerKm = GetPricePerKm(distanceInKm, daytimePrices);
            return distanceInKm * pricePerKm;
        }

        private decimal GetPricePerKm(int distanceInKm, decimal[] prices)
        {
            if (IsLongDistance(distanceInKm))
                return prices[2];
            if (IsMediumDistance(distanceInKm))
                return prices[1];
            return prices[0];
        }

        private bool IsLongDistance(int distanceInKm)
        {
            return distanceInKm > 60;
        }

        private static bool IsMediumDistance(int distanceInKm)
        {
            return distanceInKm > 20;
        }
    }
}
