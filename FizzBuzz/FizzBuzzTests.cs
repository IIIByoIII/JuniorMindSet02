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

    string ShowFizzBuzz (int inputNumber)
    {
      string variableFizzBuzz = "";
      int remainderFizz = inputNumber % 3;
      if (remainderFizz == 0)
      {
        variableFizzBuzz = "Fizz";
      }
      return variableFizzBuzz;
    }
  }
}
