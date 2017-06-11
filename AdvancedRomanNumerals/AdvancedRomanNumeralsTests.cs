using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdvancedRomanNumerals
{
  [TestClass]
  public class AdvancedRomanNumeralsTests
  {
    [TestMethod]
    public void GetRomanNumeralsFour()
    {
      Assert.AreEqual("IV", ConvertToRomanNumerals(4));
    }

    [TestMethod]
    public void GetRomanNumeralEight()
    {
        Assert.AreEqual("VIII", ConvertToRomanNumerals(8));
    }

    [TestMethod]
    public void GetRomanNumeralNine()
    {
        Assert.AreEqual("IX", ConvertToRomanNumerals(9));
    }

    [TestMethod]
    public void GetRomanNumeralFifteen()
    {
        Assert.AreEqual("XV", ConvertToRomanNumerals(15));
    }

    [TestMethod]
    public void GetRomanNumeralThirty()
    {
        Assert.AreEqual("XXX", ConvertToRomanNumerals(30));
    }

    [TestMethod]
    public void GetRomanNumeralThirtyNine()
    {
        Assert.AreEqual("XXXIX", ConvertToRomanNumerals(39));
    }

    [TestMethod]
    public void GetRomanNumeralFourtyOne()
    {
        Assert.AreEqual("XLI", ConvertToRomanNumerals(41));
    }

    [TestMethod]
    public void GetRomanNumeralFourtyFive()
    {
        Assert.AreEqual("XLV", ConvertToRomanNumerals(45));
    }

    [TestMethod]
    public void GetRomanNumeralNinetyNine()
    {
        Assert.AreEqual("XCIX", ConvertToRomanNumerals(99));
    }

    string ConvertToRomanNumerals (int numberToConvert)
    {
      string[] numeralCharacters = {"I", "V", "X", "L", "C"};
      int[] numeralValues = {1, 5, 10, 50, 100};
      Array.Reverse(numeralCharacters);
      Array.Reverse(numeralValues);
      int numberDivision;
      decimal numberRemainder;
      string romanNumeral = "";
      bool inMemory = false;
      if ((numberToConvert > 0) && (numberToConvert < 101))
      {
        int i = 0;
        foreach (var currentValue in numeralValues)
        {
          numberDivision = numberToConvert / currentValue;
          numberRemainder = numberToConvert % currentValue;
          if ((numberDivision == 1) && ((i % 2) == 1))
          {
            if ((numberRemainder / currentValue) < 0.8m)
            {
              romanNumeral += numeralCharacters[i];
            }
            else
            {
              inMemory = true;
            }
          }
          else if (numberDivision > 3)
          {
            romanNumeral += numeralCharacters[i];
            if (inMemory)
            {
              romanNumeral += numeralCharacters[i-2];
              inMemory = false;
            }
            else
            {
              romanNumeral += numeralCharacters[i-1];
            }
          }
          else if (numberDivision > 0)
          {
            for (int j = 0; j < numberDivision; j++)
            {
              romanNumeral += numeralCharacters[i];
            }
          }
          numberToConvert -= numberDivision * currentValue;
          i++;
        }
      }
      return romanNumeral;
    }
  }
}
