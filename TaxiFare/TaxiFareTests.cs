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

        decimal CalculateTaxiFare (int distanceInKm, int hour)
        {
            decimal pricePerKm = 5;
            return distanceInKm * pricePerKm;
        }
    }
}
