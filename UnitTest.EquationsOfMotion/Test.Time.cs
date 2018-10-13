using System;
using Xunit;
using static EquationsOfMotion.Time;

namespace UnitTest.EquationsOfMotion
{
    public class Test_Time
    {
        [Fact]
        public void Test_TimeFromUVA()
        {
            double result = TimeFromUVA(10, 20, 2);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Test_TimeFromSUV()
        {
            double result = TimeFromSUV(75, 10, 20);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Test_TimeFromSUA()
        {
            double result = TimeFromSUA(75, 10, 2);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Test_TimeFromSVA()
        {
            double result = TimeFromSVA(75, 20, 2);
            Assert.Equal(5, result);
        }
    }
}
