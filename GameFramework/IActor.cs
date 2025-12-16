#nullable enable

using System;
using UnityEngine;

namespace GameFramework
{
    /// <summary>
    /// Actor is the base class for an Object that has significant presence in the game world / has some functionality.
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
        /// Fired when the owner of this (or a parent Actor of this) changes.
        /// </summary>
        public event Action OnAnyOwnerChanged;
        
        /// <summary>
        /// Fired when the owner of this actor changes.
        /// </summary>
        public event Action OnOwnerChanged;

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