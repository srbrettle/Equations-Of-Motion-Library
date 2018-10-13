using System;
using Xunit;
using static srbrettle.EquationsOfMotion.Displacement;

namespace UnitTest.EquationsOfMotion
{
    public class Test_Displacement
    {
        [Fact]
        public void Test_DisplacementFromUAT()
        {
            double result = DisplacementFromUAT(10, 2, 5);
            Assert.Equal(75, result);
        }

        [Fact]
        public void Test_DisplacementFromUVT()
        {
            double result = DisplacementFromUVT(10, 20, 5);
            Assert.Equal(75, result);
        }

        [Fact]
        public void Test_DisplacementFromUVA()
        {
            double result = DisplacementFromUVA(10, 20, 2);
            Assert.Equal(75, result);
        }

        [Fact]
        public void Test_DisplacementFromVAT()
        {
            double result = DisplacementFromVAT(20, 2, 5);
            Assert.Equal(75, result);
        }
    }
}
