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
            decimal pricePerKm = 5;
            if (IsLongDistance(distanceInKm))
                pricePerKm = 6;
            else if (IsMediumDistance(distanceInKm))
                pricePerKm = 8;
            return distanceInKm * pricePerKm;
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
