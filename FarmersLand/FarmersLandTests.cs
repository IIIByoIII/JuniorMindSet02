using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FarmersLand
{
  [TestClass]
  public class FarmersLandTests
  {
    [TestMethod]
    public void LandArea()
    {
      Assert.AreEqual(592900d, InitialLandArea());
    }

    double InitialLandArea()
    {
      double initialLength = (-230 + Math.Sqrt(230 * 230 - 4 * -770000)) / 2;
      double initialArea = Math.Pow(initialLength, 2);
      return initialArea;
    }
  }
}
