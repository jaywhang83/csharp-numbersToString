using System;
using System.Collections.Generic;
using Xunit;

namespace NumberToStringNS
{
  public class NumberToStringTest
  {
    [Fact]
    public void stringGenerator_singleDigits()
    {
      NumberToString test = new NumberToString();
      Assert.Equal("one", test.StringGenerator(1));
    }
    [Fact]
    public void stringGenerator_doubleDigits()
    {
      NumberToString test = new NumberToString();
      Assert.Equal("thirty", test.StringGenerator(30));
    }
    [Fact]
    public void stringGenerator_doubleDigits2()
    {
      NumberToString test = new NumberToString();
      Assert.Equal("thirty five", test.StringGenerator(35));
    }
  }
}
