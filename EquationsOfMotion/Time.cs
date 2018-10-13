using System;

namespace EquationsOfMotion
{
    public static class Time
    {
        public static double TimefromUVA(double initialVelocity, double finalVelocity, double acceleration)
        {
            return (finalVelocity - initialVelocity) / acceleration;
        }

        public static double TimeFromSUV(double displacement, double initialVelocity, double finalVelocity)
        {
            return displacement / (0.5 * (initialVelocity + finalVelocity));
        }

        public static double[] TimeFromSUAQuadratic(double displacement, double initialVelocity, double acceleration)
        {
            double[] time = new double[2];
            time[0] = (-initialVelocity + Math.Sqrt(Math.Pow(initialVelocity, 2) + 2 * acceleration * displacement)) / acceleration;
            time[1] = (-initialVelocity - Math.Sqrt(Math.Pow(initialVelocity, 2) + 2 * acceleration * displacement)) / acceleration;
            return time;
        }

        public static double TimeFromSUA(double displacement, double initialVelocity, double acceleration)
        {
            double finalVelocity = FinalVelocity.FinalVelocityFromSUA(displacement, initialVelocity, acceleration);
            return TimefromUVA(initialVelocity, finalVelocity, acceleration);
        }

        public static double TimeFromSVA(double displacement, double finalVelocity, double acceleration)
        {
            double initialVelocity = InitialVelocity.InitialVelocityFromSVA(displacement, finalVelocity, acceleration);
            return TimefromUVA(initialVelocity, finalVelocity, acceleration);
        }
    }
}
