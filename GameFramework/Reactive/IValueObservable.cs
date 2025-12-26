using System;

namespace GameFramework.Reactive
{
    /// <summary>
    /// Exposes a simple value of type T, so systems can react to it.
    /// Every implementation of Subscribe should directly call OnNext for coherence
    /// </summary>
    /// <typeparam name="T">The type of the value to expose.</typeparam>
    public interface IValueObservable<out T> : IObservable<T>
    {
        /// <summary>
        /// Because they can be multiple simple values of the same type exposed, each one shoud have a name / a channel, so auto binding can be done.
        /// </summary>
        public string Name { get; }
        
        /// <summary>
        /// The current value being exposed.
        /// </summary>
        public T CurrentValue { get; }
    }
}