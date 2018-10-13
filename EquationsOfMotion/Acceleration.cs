using System;

namespace EquationsOfMotion
{
    /// <summary>
    /// Equations for Constant Acceleration.
    /// </summary>
    public static class Acceleration
    {
        /// <summary>
        /// Calculates Acceleration from Initial Velocity, Final Velocity and Time.
        /// </summary>
        /// <param name="initialVelocity">Initial Velocity</param>
        /// <param name="finalVelocity">Final Velocity</param>
        /// <param name="time">Time</param>
        /// <returns>Acceleration</returns>
        public static double AccelerationFromUVT(double initialVelocity, double finalVelocity, double time)
        {
            return (finalVelocity - initialVelocity) / time;
        }

        /// <summary>
        /// Calculates Acceleration from Displacement, Initial Velocity and Final Velocity.
        /// </summary>
        /// <param name="displacement">Displacement</param>
        /// <param name="initialVelocity">Initial Velocity</param>
        /// <param name="finalVelocity">Final Velocity</param>
        /// <returns>Acceleration</returns>
        public static double AccelerationFromSUV(double displacement, double initialVelocity, double finalVelocity)
        {
            return (Math.Pow(finalVelocity, 2) - Math.Pow(initialVelocity, 2)) / (2 * displacement);
        }

        /// <summary>
        /// Calculates Acceleration from Displacement, Initial Velocity and Time.
        /// </summary>
        /// <param name="displacement">Displacement</param>
        /// <param name="initialVelocity">Initial Velocity</param>
        /// <param name="time">Time</param>
        /// <returns>Acceleration</returns>
        public static double AccelerationFromSUT(double displacement, double initialVelocity, double time)
        {
            return (2 * (displacement - initialVelocity * time)) / Math.Pow(time, 2);
        }

        /// <summary>
        /// Calculates Acceleration from Displacement, Final Velocity and Time.
        /// </summary>
        /// <param name="displacement">Displacement</param>
        /// <param name="finalVelocity">Final Velocity</param>
        /// <param name="time">Time</param>
        /// <returns>Acceleration</returns>
        public static double AccelerationFromSVT(double displacement, double finalVelocity, double time)
        {
            return (2 * (finalVelocity * time - displacement) / Math.Pow(time, 2));
        }
    }
}
