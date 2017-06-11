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
      return totalToPay;
    }
  }
}
