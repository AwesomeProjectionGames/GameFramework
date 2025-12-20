namespace GameFramework.Effects
{
    /// <summary>
    /// Exposes a simple value of type T, so visual effects systems can react to it.
    /// </summary>
    /// <typeparam name="T">The type of the value to expose.</typeparam>
    public interface IExposeSimpleValue<T>
    {
        /// <summary>
        /// Because they can be multiple simple values exposed, each one shoud have a name / a channel, so auto binding can be done.
        /// </summary>
        public string Name { get; }
        
        /// <summary>
        /// The current value being exposed.
        /// </summary>
        public T CurrentValue { get; }
        
        /// <summary>
        /// Event invoked when the value changes.
        /// </summary>
        public event System.Action<T>? OnValueChanged;
    }
}