#nullable enable

using System;
using System.Collections.Generic;

namespace GameFramework.Dependencies
{
    /// <summary>
    /// A container that can hold components (can be MonoBehavior or not, like IActorComponent).
    /// </summary>
    public interface IComponentsContainer
    {
        /// <summary>
        /// Find a component of type T attached to this container (can or cannot be MonoBehavior).
        /// The class implementing this interface should cache the components in a map of type to component list for performance, so you can expect O(1) complexity on this call.
        /// </summary>
        /// <typeparam name="T">A type (implements IActorComponent or a mono behavior for example)</typeparam>
        /// <returns>Return the first component of type T if it exists, otherwise null.</returns>
        public T? GetComponent<T>();
        
        /// <summary>
        /// Find a component of the specified type attached to this container (can or cannot be MonoBehavior).
        /// The class implementing this interface should cache the components in a map of type to component list for performance, so you can expect O(1) complexity on this call.
        /// </summary>
        /// <param name="componentType">A type (implements IActorComponent or a mono behavior for example)</param>
        /// <returns>Return the first component of the specified type if it exists, otherwise null.</returns>
        public object? GetComponent(Type componentType);
        
        /// <summary>
        /// Find all components of type T attached to this container (can or cannot be MonoBehavior).
        /// The class implementing this interface should cache the components in a map of type to component list for performance, so you can expect O(1) complexity on this call.
        /// </summary>
        /// <typeparam name="T">A type (implements IActorComponent or a mono behavior for example)</typeparam>
        /// <returns>>Return all components of type T if they exist, otherwise an empty array.</returns>
        public IReadOnlyList<T> GetComponents<T>();
    }
}