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

    decimal RentAndDebt (decimal rentValue, uint daysLate)
    {
      decimal totalToPay = 0;
      totalToPay = rentValue + daysLate * (rentValue * 0.02m);
      return totalToPay;
    }
  }
}
