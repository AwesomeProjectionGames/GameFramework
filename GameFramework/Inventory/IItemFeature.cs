using System;

namespace GameFramework.Inventory
{
    /// <summary>
    /// A feature is a special behavior for items or a category that permit filtering
    /// </summary>
    public interface IItemFeature
    {
        /// <summary>
        /// Serialized state (preferably in JSON format) of the feature.
        /// </summary>
        string SerializedState { get; }
        
        string LocalizedName { get; }
        
        /// <summary>
        /// Apply the state to the feature.
        /// </summary>
        /// <param name="serializedState">The serialized state to apply.</param>
        void ApplyState(string serializedState);
        
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