using System;

namespace EquationsOfMotion
{
    public class Time
    {
        public static double TimefromUVA(double initialVelocity, double finalVelocity, double acceleration)
        {
            return (finalVelocity - initialVelocity) / acceleration;
        }

        public static double TimeFromUVS(double initialVelocity, double finalVelocity, double displacement)
        {
            return displacement / (0.5 * (initialVelocity + finalVelocity));
        }

        public static double[] TimeFromUAS(double initialVelocity, double acceleration, double displacement)
        {
            double[] time = new double[2];
            time[0] = (-initialVelocity + Math.Sqrt(Math.Pow(initialVelocity, 2) + 2 * acceleration * displacement)) / acceleration;
            time[1] = (-initialVelocity - Math.Sqrt(Math.Pow(initialVelocity, 2) + 2 * acceleration * displacement)) / acceleration;
            return time;
        }
    }
}
