#nullable enable

using System;
using GameFramework.Identification;

namespace GameFramework
{
    /// <summary>
    /// An entity that can be possessed by any other actor, like a player or an AI.
    /// </summary>
    public interface IActor : IEntity, IHaveUUID
    {
        /// <summary>
        /// The path to load this actor's prefab from a Resources folder (without extension),
        /// allowing it to be instantiated at runtime via Resources.Load.
        /// Each instance derived from the same prefab shares the same ResourcePath.
        /// Don't confuse with UUID, which is unique for each instance.
        /// </summary>
        string ResourcePath { get; }

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
        /// Generally called by the controller when it unpossess this actor.
        /// Look at UnpossessPawn of IController if you want to unpossess a pawn.
        /// </summary>
        void RemoveOwner();
    }
}
