using System;

namespace EquationsOfMotion
{
    public static class Displacement
    {
        public static double DisplacementFromUAT(double initialVelocity, double acceleration, double time)
        {
            return initialVelocity * time + 0.5 * acceleration * Math.Pow(time, 2);
        }

        public static double DisplacementFromUVT(double initialVelocity, double finalVelocity, double time)
        {
            return 0.5 * (initialVelocity + finalVelocity) * time;
        }

        public static double DisplacementFromUVA(double initialVelocity, double finalVelocity, double acceleration)
        {
            return (Math.Pow(finalVelocity, 2) - Math.Pow(initialVelocity, 2)) / (2 * acceleration);
        }

        public static double DisplacementFromVAT(double finalVelocity, double acceleration, double time)
        {
            double initialVelocity = InitialVelocity.InitialVelocityFromVAT(finalVelocity, acceleration, time);
            return DisplacementFromUAT(initialVelocity, acceleration, time);
        }
    }
}
