using System;

namespace EquationsOfMotion
{
    public static class Acceleration
    {
        public static double AccelerationsFromUVT(double initialVelocity, double finalVelocity, double time)
        {
            return (finalVelocity - initialVelocity) / time;
        }

        public static double AccelerationsFromSUV(double displacement, double initialVelocity, double finalVelocity)
        {
            return (Math.Pow(finalVelocity, 2) - Math.Pow(initialVelocity, 2)) / (2 * displacement);
        }

        public static double AccelerationsFromSUT(double displacement, double initialVelocity, double time)
        {
            return (2 * (displacement - initialVelocity * time)) / Math.Pow(time, 2);
        }

        public static double AccelerationsFromSVT(double displacement, double finalVelocity, double time)
        {
            return (2 * (finalVelocity * time - displacement) / Math.Pow(time, 2));
        }
    }
}
