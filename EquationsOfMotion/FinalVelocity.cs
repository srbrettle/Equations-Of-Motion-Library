using System;

namespace EquationsOfMotion
{
    /// <summary>
    /// Equations for Final Velocity.
    /// </summary>
    public static class FinalVelocity
    {
        /// <summary>
        /// Calculates Final Velocity from Initial Velocity, Acceleration and Time.
        /// </summary>
        /// <param name="initialVelocity">Initial Velocity</param>
        /// <param name="acceleration">Acceleration</param>
        /// <param name="time">Time</param>
        /// <returns>Final Velocity</returns>
        public static double FinalVelocityFromUAT(double initialVelocity, double acceleration, double time)
        {
            return initialVelocity + acceleration * time;
        }

        /// <summary>
        /// Calculates Final Velocity from Displacement, Initial Velocity and Acceleration.
        /// </summary>
        /// <param name="displacement">Displacement</param>
        /// <param name="initialVelocity">Initial Velocity</param>
        /// <param name="acceleration">Acceleration</param>
        /// <returns>Final Velocity</returns>
        public static double FinalVelocityFromSUA(double displacement, double initialVelocity, double acceleration)
        {
            return Math.Sqrt((Math.Pow(initialVelocity, 2) + 2 * acceleration * displacement));
        }

        /// <summary>
        /// Calculates Final Velocity from Displacement, Initial Velocity and Time.
        /// /// </summary>
        /// <param name="displacement">Displacement</param>
        /// <param name="initialVelocity">Initial Velocity</param>
        /// <param name="time">Time</param>
        /// <returns>Final Velocity</returns>
        public static double FinalVelocityFromSUT(double displacement, double initialVelocity, double time)
        {
            return (2 * displacement) / time - initialVelocity;
        }

        /// <summary>
        /// Calculates Final Velocity from Displacement, Acceleration and Time.
        /// </summary>
        /// <param name="displacement">Displacement</param>
        /// <param name="acceleration">Acceleration</param>
        /// <param name="time">Time</param>
        /// <returns>Final Velocity</returns>
        public static double FinalVelocityFromSAT(double displacement, double acceleration, double time)
        {
            return (displacement + 0.5 * acceleration * Math.Pow(time, 2)) / time;
        }
    }
}
