using System;

namespace EquationsOfMotion
{
    public class Time
    {
        public static double TimefromUVA(double initialVelocity, double finalVelocity, double acceleration)
        {
            return (finalVelocity - initialVelocity) / acceleration;
        }

        public static double TimeFromSUV(double displacement, double initialVelocity, double finalVelocity)
        {
            return displacement / (0.5 * (initialVelocity + finalVelocity));
        }

        public static double[] TimeFromSUA(double displacement, double initialVelocity, double acceleration)
        {
            double[] time = new double[2];
            time[0] = (-initialVelocity + Math.Sqrt(Math.Pow(initialVelocity, 2) + 2 * acceleration * displacement)) / acceleration;
            time[1] = (-initialVelocity - Math.Sqrt(Math.Pow(initialVelocity, 2) + 2 * acceleration * displacement)) / acceleration;
            return time;
        }
    }
}
