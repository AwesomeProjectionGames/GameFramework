namespace GameFramework
{
    /// <summary>
    /// An interface for objects that require regular updates or "ticks".
    /// </summary>
    public interface ITickable
    {
        /// <summary>
        /// Called every frame to update the object's state.
        /// </summary>
        /// <param name="deltaTime">Time elapsed since the last tick.</param>
        void Tick(float deltaTime);
    }
}