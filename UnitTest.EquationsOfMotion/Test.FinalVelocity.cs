using System;
using Xunit;
using static EquationsOfMotion.FinalVelocity;

namespace UnitTest.EquationsOfMotion
{
    public class Test_FinalVelocity
    {
        [Fact]
        public void Test_FinalVelocityFromUAT()
        {
            double result = FinalVelocityFromUAT(10, 2, 5);
            Assert.Equal(20, result);
        }

        [Fact]
        public void Test_FinalVelocityFromSUA()
        {
            double result = FinalVelocityFromSUA(75, 10, 2);
            Assert.Equal(20, result);
        }

        [Fact]
        public void Test_FinalVelocityFromSUT()
        {
            double result = FinalVelocityFromSUT(75, 10, 5);
            Assert.Equal(20, result);
        }

        [Fact]
        public void Test_FinalVelocityFromSAT()
        {
            double result = FinalVelocityFromSAT(75, 2, 5);
            Assert.Equal(20, result);
        }
    }
}
