using System;

namespace EquationsOfMotion
{
    public class InitialVelocity
    {
        public static double InitialVelocityFromSAT(double displacement, double acceleration, double time)
        {
            return (displacement - (0.5 * acceleration * Math.Pow(time, 2))) / time;
        }

        public static double InitialVelocityFromVTS(double finalVelocity, double time, double displacement)
        {
            return 2 * displacement / time - finalVelocity;
        }        

        public static double InitialVelocityFromVAS(double finalVelocity, double acceleration, double displacement)
        {
            return Math.Sqrt(Math.Pow(finalVelocity, 2) - 2 * acceleration * displacement);
        }

        public static double InitialVelocityFromVAT(double finalVelocity, double acceleration, double time)
        {
            return finalVelocity - acceleration * time;
        }
    }
}
