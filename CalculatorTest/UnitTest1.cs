using System;
using Xunit;
using UTCalculator; // Needed to access UTCalculator class

namespace CalculatorTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddMethodResultShouldBeNine()
        {
            int result = CalculatorFeatures.AddTwoNumbers(5, 4);
            Assert.Equal(9, result);
        }
    }
}
