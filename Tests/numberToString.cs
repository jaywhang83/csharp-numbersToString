using System;
using System.Collections.Generic;
using Xunit;

namespace NumberToStringNS
{
  public class NumberToStringTest
  {
    [Fact]
    public void stringGenerator_singleDigit()
    {
      NumberToString test = new NumberToString();
      Assert.Equal("one", test.StringGenerator(1));
    }

  }
}
