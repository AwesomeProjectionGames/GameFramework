using System;

namespace GameFramework.Bus
{
    /// <summary>
    /// Interface for a simple event bus system.
    /// As they can be multiple event bus in the game, this interface does not implement any singleton pattern.
    /// Event bus allows decoupled communication between different parts of the system by subscribing to and raising events.
    /// They are generally one event bus per context / topic / domain and sometimes a local event bus (like entity I/O ports) for an actor (can be used for other purposes than global event bus).
    /// </summary>
    public interface IEventBus
    {
        /// <summary>
        /// Subscribe to a specific event type (T)
        /// </summary>
        /// <param name="handler">Handler to invoke when the event of type T is published. It should be a method (not a lambda) to be able to unsubscribe later.</param>
        /// <typeparam name="T">Type of the event to subscribe to. Must be a struct to avoid performance issues with boxing.</typeparam>
        void Subscribe<T>(Action<T> handler) where T : struct;
    
        /// <summary>
        /// Unsubscribe to prevent memory leaks.
        /// </summary>
        /// <param name="handler">Handler to remove from the subscription list.</param>
        /// <typeparam name="T">Type of the event to unsubscribe from. Must be a struct to avoid performance issues with boxing.</typeparam>
        void Unsubscribe<T>(Action<T> handler) where T : struct;
    
        /// <summary>
        /// Fire / raise the event of type T to all subscribers.
        /// </summary>
        /// <param name="eventItem">Event item to publish.</param>
        /// <typeparam name="T">Type of the event to publish. Must be a struct to avoid performance issues with boxing.</typeparam>
        void Publish<T>(T eventItem) where T : struct;
    }
}