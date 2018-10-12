using System;

namespace EquationsOfMotion
{
    public class InitialVelocity
    {
        public static double InitialVelocityFromSAT(double displacement, double acceleration, double time)
        {
            return (displacement - (0.5 * acceleration * Math.Pow(time, 2))) / time;
        }

        public static double InitialVelocityFromSVT(double displacement, double finalVelocity, double time)
        {
            return 2 * displacement / time - finalVelocity;
        }        

        public static double InitialVelocityFromSVA(double displacement, double finalVelocity, double acceleration)
        {
            return Math.Sqrt(Math.Pow(finalVelocity, 2) - 2 * acceleration * displacement);
        }

        public static double InitialVelocityFromVAT(double finalVelocity, double acceleration, double time)
        {
            return finalVelocity - acceleration * time;
        }
    }
}
