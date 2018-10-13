using System;

namespace srbrettle.EquationsOfMotion
{
    /// <summary>
    /// Equations for Time.
    /// </summary>
    public static class Time
    {
        /// <summary>
        /// Calculates Time from Initial Velocity, Final Velocity and Acceleration. 
        /// </summary>
        /// <param name="initialVelocity">Initial Velocity</param>
        /// <param name="finalVelocity">Final Velocity</param>
        /// <param name="acceleration">Acceleration</param>
        /// <returns></returns>
        public static double TimeFromUVA(double initialVelocity, double finalVelocity, double acceleration)
        {
            return (finalVelocity - initialVelocity) / acceleration;
        }

        /// <summary>
        /// Calculates Time from Displacement, Initial Velocity and Final Velocity.
        /// </summary>
        /// <param name="displacement">Displacement</param>
        /// <param name="initialVelocity">Initial Velocity</param>
        /// <param name="finalVelocity">Final Velocity</param>
        /// <returns></returns>
        public static double TimeFromSUV(double displacement, double initialVelocity, double finalVelocity)
        {
            return displacement / (0.5 * (initialVelocity + finalVelocity));
        }

        /// <summary>
        /// Calculates Time from Displacement, Initial Velocity and Acceleration.  
        /// </summary>
        /// <param name="displacement">Displacement</param>
        /// <param name="initialVelocity">Initial Velocity</param>
        /// <param name="acceleration">Acceleration</param>
        /// <returns></returns>
        public static double[] TimeFromSUAQuadratic(double displacement, double initialVelocity, double acceleration)
        {
            double[] time = new double[2];
            time[0] = (-initialVelocity + Math.Sqrt(Math.Pow(initialVelocity, 2) + 2 * acceleration * displacement)) / acceleration;
            time[1] = (-initialVelocity - Math.Sqrt(Math.Pow(initialVelocity, 2) + 2 * acceleration * displacement)) / acceleration;
            return time;
        }

        /// <summary>
        /// Calculates Time from Displacement, Initial Velocity and Acceleration.  
        /// </summary>
        /// <param name="displacement">Displacement</param>
        /// <param name="initialVelocity">Initial Velocity</param>
        /// <param name="acceleration">Acceleration</param>
        /// <returns></returns>
        public static double TimeFromSUA(double displacement, double initialVelocity, double acceleration)
        {
            double finalVelocity = FinalVelocity.FinalVelocityFromSUA(displacement, initialVelocity, acceleration);
            return TimeFromUVA(initialVelocity, finalVelocity, acceleration);
        }

        /// <summary>
        /// Calculates Time from Displacement, Final Velocity and Acceleration.  
        /// </summary>
        /// <param name="displacement">Displacement</param>
        /// <param name="finalVelocity">Final Velocity</param>
        /// <param name="acceleration">Acceleration</param>
        /// <returns></returns>
        public static double TimeFromSVA(double displacement, double finalVelocity, double acceleration)
        {
            double initialVelocity = InitialVelocity.InitialVelocityFromSVA(displacement, finalVelocity, acceleration);
            return TimeFromUVA(initialVelocity, finalVelocity, acceleration);
        }
    }
}
