#nullable enable

namespace GameFramework.Effects
{
    /// <summary>
    /// Usefull for objects that react to simple value changes (like health, stamina, etc).
    /// </summary>
    public interface ISimpleValueReactor<T>
    {
        /// <summary>
        /// The source of the simple value to observe.
        /// </summary>
        public IExposeSimpleValue<T>? ObservedSource { get; set; }
        
        /// <summary>
        /// Called when the observed source changes.
        /// </summary>
        /// <param name="oldSource">The previous source.</param>
        /// <param name="newSource">The new source.</param>
        protected void OnObservedSourceChanged(IExposeSimpleValue<T>? oldSource, IExposeSimpleValue<T>? newSource);
        
        /// <summary>
        /// Called when the observed value changes.
        /// </summary>
        /// <param name="newValue">The new value.</param>
        protected void OnObservedValueChanged(T newValue);
    }
}