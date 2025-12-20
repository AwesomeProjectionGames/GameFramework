namespace GameFramework.Effects
{
    /// <summary>
    /// Usefull for objects that react to simple value changes (like health, stamina, etc).
    /// </summary>
    public interface ISimpleValueReactor<T>
    {
        /// <summary>
        /// Because you can have multiple ISimpleValueReactor<float>, this is a channel identifier to distinguish the value that they should react to.
        /// </summary>
        public string ReactorChannel { get; }
        /// <summary>
        /// Called when the value changes.
        /// </summary>
        /// <param name="newValue">The new value.</param>
        public void OnValueChanged(T newValue);
    }
}