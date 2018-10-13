using System;

namespace EquationsOfMotion
{
    public static class FinalVelocity
    {
        public static double FinalVelocityFromUAT(double initialVelocity, double acceleration, double time)
        {
            return initialVelocity + acceleration * time;
        }

        public static double FinalVelocityFromSUA(double displacement, double initialVelocity, double acceleration)
        {
            return Math.Sqrt((Math.Pow(initialVelocity, 2) + 2 * acceleration * displacement));
        }

        public static double FinalVelocityFromSUT(double displacement, double initialVelocity, double time)
        {
            return (2 * displacement) / time - initialVelocity;
        }

        public static double FinalVelocityFromSAT(double displacement, double acceleration, double time)
        {
            return (displacement + 0.5 * acceleration * Math.Pow(time, 2)) / time;
        }
    }
}
