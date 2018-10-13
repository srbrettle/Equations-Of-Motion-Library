using System;

namespace srbrettle.EquationsOfMotion
{
    /// <summary>
    /// Equations for Displacement.
    /// </summary>
    public static class Displacement
    {
        /// <summary>
        /// Calculates Displacement from Initial Velocity, Acceleration and Time.
        /// </summary>
        /// <param name="initialVelocity">Initial Velocity</param>
        /// <param name="acceleration">Acceleration</param>
        /// <param name="time">Time</param>
        /// <returns>Displacement</returns>
        public static double DisplacementFromUAT(double initialVelocity, double acceleration, double time)
        {
            return initialVelocity * time + 0.5 * acceleration * Math.Pow(time, 2);
        }

        /// <summary>
        /// Calculates Displacement from Initial Velocity, Final Velocity and Time.
        /// </summary>
        /// <param name="initialVelocity">Initial Velocity</param>
        /// <param name="finalVelocity">Final Velocity</param>
        /// <param name="time">Time</param>
        /// <returns>Displacement</returns>
        public static double DisplacementFromUVT(double initialVelocity, double finalVelocity, double time)
        {
            return 0.5 * (initialVelocity + finalVelocity) * time;
        }

        /// <summary>
        /// Calculates Displacement from Initial Velocity, Final Velocity and Acceleration.
        /// </summary>
        /// <param name="initialVelocity">Initial Velocity</param>
        /// <param name="finalVelocity">Final Velocity</param>
        /// <param name="acceleration">Acceleration</param>
        /// <returns>Displacement</returns>
        public static double DisplacementFromUVA(double initialVelocity, double finalVelocity, double acceleration)
        {
            return (Math.Pow(finalVelocity, 2) - Math.Pow(initialVelocity, 2)) / (2 * acceleration);
        }

        /// <summary>
        /// Calculates Displacement from Final Velocity, Acceleration and Time.
        /// </summary>
        /// <param name="finalVelocity">Initial Velocity</param>
        /// <param name="acceleration">Acceleration</param>
        /// <param name="time">Time</param>
        /// <returns>Displacement</returns>
        public static double DisplacementFromVAT(double finalVelocity, double acceleration, double time)
        {
            double initialVelocity = InitialVelocity.InitialVelocityFromVAT(finalVelocity, acceleration, time);
            return DisplacementFromUAT(initialVelocity, acceleration, time);
        }
    }
}
