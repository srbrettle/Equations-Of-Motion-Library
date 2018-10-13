using System;
using Xunit;
using static srbrettle.EquationsOfMotion.InitialVelocity;

namespace UnitTest.EquationsOfMotion
{
    public class Test_InitialVelocity
    {
        [Fact]
        public void Test_InitialVelocityFromSAT()
        {
            double result = InitialVelocityFromSAT(75, 2, 5);
            Assert.Equal(10, result);
        }

        [Fact]
        public void Test_InitialVelocityFromSVT()
        {
            double result = InitialVelocityFromSVT(75, 20, 5);
            Assert.Equal(10, result);
        }

        [Fact]
        public void Test_InitialVelocityFromSVA()
        {
            double result = InitialVelocityFromSVA(75, 20, 2);
            Assert.Equal(10, result);
        }

        [Fact]
        public void Test_InitialVelocityFromVAT()
        {
            double result = InitialVelocityFromVAT(20, 2, 5);
            Assert.Equal(10, result);
        }
    }
}
