using System;

namespace EquationsOfMotion
{
    public class Acceleration
    {
        public static double AccelerationsFromUVT(double initialVelocity, double finalVelocity, double time)
        {
            return (finalVelocity - initialVelocity) / time;
        }

        public static double AccelerationsFromUVS(double initialVelocity, double finalVelocity, double displacement)
        {
            return (Math.Pow(finalVelocity, 2) - Math.Pow(initialVelocity, 2)) / (2 * displacement);
        }

        public static double AccelerationsFromUTS(double initialVelocity, double time, double displacement)
        {
            return (2 * (displacement - initialVelocity * time)) / Math.Pow(time, 2);
        }        
    }
}
