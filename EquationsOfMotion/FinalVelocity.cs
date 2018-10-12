using System;

namespace EquationsOfMotion
{
    public class FinalVelocity
    {
        public static double FinalVelocityFromUAT(double initialVelocity, double acceleration, double time)
        {
            return initialVelocity + acceleration * time;
        }

        public static double FinalVelocityFromUAS(double initialVelocity, double acceleration, double displacement)
        {
            return Math.Sqrt((Math.Pow(initialVelocity, 2) + 2 * acceleration * displacement));
        }

        public static double FinalVelocityFromUTS(double initialVelocity, double time, double displacement)
        {
            return (2 * displacement) / time - initialVelocity;
        }
    }
}
