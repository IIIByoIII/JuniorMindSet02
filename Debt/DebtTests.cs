using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Debt
{
  [TestClass]
  public class DebtTests
  {
    [TestMethod]
    public void PaidUpToTenDays()
    {
      Assert.AreEqual(110, RentAndDebt(100, 5));
    }

    [TestMethod]
    public void PaidUpToThirtyDays()
    {
      Assert.AreEqual(175, RentAndDebt(100, 15));
    }

    [TestMethod]
    public void PaidUpToFourtyDays()
    {
      Assert.AreEqual(450, RentAndDebt(100, 35));
    }

    [TestMethod]
    public void PaidOverFourtyDays()
    {
      Assert.AreEqual(500, RentAndDebt(100, 45));
    }

    decimal RentAndDebt (decimal rentValue, uint daysLate)
    {
      decimal totalToPay = 0;
      if (daysLate < 11)
      {
        totalToPay = rentValue + daysLate * (rentValue * 0.02m);
      }
      else if (daysLate < 31)
      {
        totalToPay = rentValue + daysLate * (rentValue * 0.05m);
      }
      else if (daysLate < 41)
      {
        totalToPay = rentValue + daysLate * (rentValue * 0.1m);
      }
      else
      {
        totalToPay = rentValue + 40 * (rentValue * 0.1m);
      }
      return totalToPay;
    }
  }
}
