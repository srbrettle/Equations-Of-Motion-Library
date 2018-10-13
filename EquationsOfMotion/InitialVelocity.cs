using System;

namespace EquationsOfMotion
{
    /// <summary>
    /// Equations for Initial Velocity.
    /// </summary>
    public static class InitialVelocity
    {
        /// <summary>
        /// Calculates Initial Velocity from Displacement, Acceleration and Time.
        /// </summary>
        /// <param name="displacement">Displacement</param>
        /// <param name="acceleration">Acceleration</param>
        /// <param name="time">Time</param>
        /// <returns></returns>
        public static double InitialVelocityFromSAT(double displacement, double acceleration, double time)
        {
            return (displacement - (0.5 * acceleration * Math.Pow(time, 2))) / time;
        }

        /// <summary>
        /// Calculates Initial Velocity from Displacement, Final Velocity and Time. 
        /// </summary>
        /// <param name="displacement">Displacement</param>
        /// <param name="finalVelocity">Final Velocity</param>
        /// <param name="time">Time</param>
        /// <returns></returns>
        public static double InitialVelocityFromSVT(double displacement, double finalVelocity, double time)
        {
            return 2 * displacement / time - finalVelocity;
        }

        /// <summary>
        /// Calculates Initial Velocity from Displacement, Final Velocity and Acceleration. 
        /// </summary>
        /// <param name="displacement">Displacement</param>
        /// <param name="finalVelocity">Final Velocity</param>
        /// <param name="acceleration">Acceleration</param>
        /// <returns></returns>
        public static double InitialVelocityFromSVA(double displacement, double finalVelocity, double acceleration)
        {
            return Math.Sqrt(Math.Pow(finalVelocity, 2) - 2 * acceleration * displacement);
        }

        /// <summary>
        /// Calculates Initial Velocity from Final Velocity, Acceleration and Time. 
        /// </summary>
        /// <param name="finalVelocity">Final Velocity</param>
        /// <param name="acceleration">Acceleration</param>
        /// <param name="time">Time</param>
        /// <returns></returns>
        public static double InitialVelocityFromVAT(double finalVelocity, double acceleration, double time)
        {
            return finalVelocity - acceleration * time;
        }
    }
}
