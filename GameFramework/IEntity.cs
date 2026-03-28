using GameFramework.Bus;
using GameFramework.Dependencies;
using UnityEngine;

namespace GameFramework
{
    /// <summary>
    /// The base class for an Object that has significant presence in the game world / has some functionality
    /// Entities can have specials features to compose its behavior through components (see IComponentsContainer) and can dispatch events through its own event bus (see IEventBus).
    /// </summary>
    public interface IEntity
    {
        Transform Transform { get; }

        /// <summary>
        /// The event bus associated with this entity. Like a Event Dispatcher owned by an Actor in unreal terminology.
        /// It should be used to dispatch events related to this entity only and should follow the same lifetime as the entity itself.
        /// </summary>
        public IEventBus EventDispatcher { get; }
        
        /// <summary>
        /// The components container for this actor.
        /// </summary>
        public IComponentsContainer ComponentsContainer { get; }
    }
}