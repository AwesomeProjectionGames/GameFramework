using System;

namespace GameFramework
{
    public enum TickType { Update, FixedUpdate }

    /// <summary>
    /// Distributes update ticks across multiple frames to load-balance CPU operations.
    /// </summary>
    public interface ITickDistributor
    {
        /// <summary>
        /// Registers a callback to be fired on a distributed schedule.
        /// </summary>
        /// <param name="callback">The method to execute.</param>
        /// <param name="tickType">Whether to hook into Update or FixedUpdate.</param>
        void Subscribe(Action callback, TickType tickType);

        /// <summary>
        /// Unregisters a callback. Fails silently if the callback is not registered.
        /// </summary>
        void Unsubscribe(Action callback, TickType tickType);
    }
}