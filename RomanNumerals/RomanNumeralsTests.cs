using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumerals
{
  [TestClass]
  public class RomanNumeralsTests
  {
    [TestMethod]
    public void GetRomanNumeralFour()
    {
        Assert.AreEqual("IV", ConvertToRomanNumerals(4));
    }

    string ConvertToRomanNumerals (int numberToConvert)
    {
      string[] numeralCharacters = {"I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC", "C"};
      int[] numeralValues = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100};
      Array.Reverse(numeralCharacters);
      Array.Reverse(numeralValues);
      int numberDivision;
      int i = 0;
      string romanNumeral = "";
      foreach (int currentValue in numeralValues) 
      {
        numberDivision = numberToConvert / currentValue;
        if (numberDivision == 1)
        {
          romanNumeral = $"{romanNumeral}{numeralCharacters[i]}";
          numberToConvert -= currentValue;
        }
        i++;
      }
      return romanNumeral;
    }
  }
}
