using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Watermelon
{
  [TestClass]
  public class WatermelonTests
  {
    [TestMethod]
    public void WeightIsEven()
    {
      Assert.AreEqual("DA", WeightDivision(4));
    }

    string WeightDivision (int watermelonMass)
    {
      string divideEqually;
      int massIsOdd = watermelonMass % 2;
      if ( massIsOdd == 1 )
      {
          divideEqually = "NU";
      }
      else
      {
          divideEqually = "DA";
      }
      return divideEqually;
    }
  }
}
