using System;
using Xunit;
using static srbrettle.EquationsOfMotion.Acceleration;

namespace UnitTest.EquationsOfMotion
{
    public class Test_Acceleration
    {
        [Fact]
        public void Test_AccelerationsFromUVT()
        {
            double result = AccelerationFromUVT(10, 20, 5);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Test_AccelerationsFromSUV()
        {
            double result = AccelerationFromSUV(75, 10, 20);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Test_AccelerationsFromSUT()
        {
            double result = AccelerationFromSUT(75, 10, 5);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Test_AccelerationsFromSVT()
        {
            double result = AccelerationFromSVT(75, 20, 5);
            Assert.Equal(2, result);
        }
    }
}
