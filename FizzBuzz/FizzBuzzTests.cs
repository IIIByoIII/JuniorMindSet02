using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
  [TestClass]
  public class FizzBuzzTests
  {
    [TestMethod]
    public void WillItFizz()
    {
      Assert.AreEqual("Fizz", ShowFizzBuzz(6));
    }

    [TestMethod]
    public void WillItBuzz()
    {
      Assert.AreEqual("Buzz", ShowFizzBuzz(10));
    }

    string ShowFizzBuzz (int inputNumber)
    {
      string variableFizzBuzz = "";
      int remainderFizz = inputNumber % 3;
      int remainderBuzz = inputNumber % 5;
      if (remainderFizz == 0)
      {
        variableFizzBuzz = "Fizz";
      }
      if (remainderBuzz == 0)
      {
        variableFizzBuzz = "Buzz";
      }
      return variableFizzBuzz;
    }
  }
}
