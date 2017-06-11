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

    [TestMethod]
    public void WeightIsOdd()
    {
      Assert.AreEqual("NU", WeightDivision(5));
    }

    [TestMethod]
    public void WeightIsOverThree()
    {
      Assert.AreEqual("NU", WeightDivision(2));
    }

    string WeightDivision (int watermelonMass)
    {
      if ( watermelonMass > 3 )
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
      else
      {
        return "NU";
      }
    }
  }
}
