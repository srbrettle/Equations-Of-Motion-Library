using System;
using Xunit;
using static EquationsOfMotion.Acceleration;

namespace UnitTest.EquationsOfMotion
{
    public class Acceleration
    {
        [Fact]
        public void Test_AccelerationsFromUVT()
        {
            double result = AccelerationsFromUVT(10, 20, 5);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Test_AccelerationsFromSUV()
        {
            double result = AccelerationsFromSUV(75, 10, 20);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Test_AccelerationsFromSUT()
        {
            double result = AccelerationsFromSUT(75, 10, 5);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Test_AccelerationsFromSVT()
        {
            double result = AccelerationsFromSVT(75, 20, 5);
            Assert.Equal(2, result);
        }
    }
}