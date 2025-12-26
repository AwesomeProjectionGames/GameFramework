#nullable enable

using System;

namespace GameFramework.Reactive
{
    /// <summary>
    /// Usefull for objects that react to simple value changes (like health, stamina, etc).
    /// </summary>
    public interface IValueObserver<T> : IObserver<T>
    {
        /// <summary>
        /// The source of the simple value to observe.
        /// </summary>
        public IValueObservable<T>? ObservedSource { get; set; }
    }
}