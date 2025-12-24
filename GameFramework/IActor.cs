#nullable enable

using System;
using System.Collections.Generic;
using GameFramework.Bus;
using GameFramework.GameFramework;
using GameFramework.Identification;
using UnityEngine;

namespace GameFramework
{
    /// <summary>
    /// Actor is the base class for an Object that has significant presence in the game world / has some functionality (like an entity).
    /// It can be possessed by any other actor, like a player or an AI.
    /// </summary>
    public interface IActor : IHaveUUID
    {
        Transform Transform { get; }
        
        /// <summary>
        /// Gets the controller currently possessing this actor.
        /// </summary>
        public IController? Controller => Owner?.Controller;
         
        /// <summary>
        /// The controller currently possessing this pawn. Null if unpossessed.
        /// </summary>
        public IActor? Owner { get; }
        
        /// <summary>
        /// The event bus associated with this entity. Like a Event Dispatcher owned by an Actor in unreal terminology.
        /// It should be used to dispatch events related to this entity only and should follow the same lifetime as the entity itself.
        /// </summary>
        public IEventBus EventDispatcher { get; }
        
        /// <summary>
        /// Fired when the owner of this (or a parent Actor of this) changes.
        /// </summary>
        public event Action OnAnyOwnerChanged;
        
        /// <summary>
        /// Fired when the owner of this actor changes.
        /// </summary>
        public event Action OnOwnerChanged;
        
        /// <summary>
        /// Find a component of type T attached to this actor.
        /// The class implementing this interface should cache the components in a map of type to component list for performance, so you can expect O(1) complexity on this call.
        /// </summary>
        /// <typeparam name="T">A type that implements IActorComponent</typeparam>
        /// <returns>Return the first component of type T if it exists, otherwise null.</returns>
        public T? GetActorComponent<T>() where T : IActorComponent;
        
        /// <summary>
        /// Find all components of type T attached to this actor.
        /// </summary>
        /// <typeparam name="T">A type that implements IActorComponent</typeparam>
        /// <returns>>Return all components of type T if they exist, otherwise an empty array.</returns>
        public IReadOnlyList<T> GetActorComponents<T>() where T : IActorComponent;

        /// <summary>
        /// Called when the actor is owned by an other actor.
        /// This should be called automatically when a controller possess pawn (by the controller)
        /// </summary>
        /// <param name="newOwner">The owner taking possession of this actor</param>
        void SetOwner(IActor newOwner);

        /// <summary>
        /// Called when the actor is unpossessed.
        /// </summary>
        void RemoveOwner();
    }
}