using System;
using GameFramework.Dependencies;

namespace GameFramework.Dependencies
{
    /// <summary>
    /// A feature is a special behavior for items or a category that permit filtering
    /// </summary>
    public interface IActorComponentWithState : IActorComponent, ISerializedObject
    {
        /// <summary>
        /// When the state of the feature changes, this method should be called to notify listeners.
        /// </summary>
        void NotifyStateChanged();
        
        /// <summary>
        /// Invoked when the state of the feature changes.
        /// The bool is true if it's comming from a save/load operation (ApplyState), false if it's a manual change (NotifyStateChanged).
        /// </summary>
        event Action<bool> OnStateChangedNotification;
    }
}