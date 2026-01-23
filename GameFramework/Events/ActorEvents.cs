#nullable enable

namespace GameFramework.Events
{
    /// <summary>
    /// Events on the local actor bus should inherit from this class.
    /// Should be used for high-frequency or volatile intra-entity signals.
    /// </summary>
    public abstract class ActorEvent 
    {
        public IActor Actor { get; }

        /// <summary>
        /// Quick check to see if the local client is the one controlling this actor.
        /// </summary>
        public bool IsLocalOwner { get; }

        protected ActorEvent(IActor actor, bool isLocalOwner = true)
        {
            Actor = actor;
            IsLocalOwner = isLocalOwner;
        }
    }

    /// <summary>
    /// Fired when an actor requests an ownership transfer back to the server.
    /// </summary>
    public sealed class OnActorWantsToGiveBackOwnershipEvent : ActorEvent
    {
        public OnActorWantsToGiveBackOwnershipEvent(IActor actor) : base(actor) { }
    }
    
    /// <summary>
    /// Fired when an actor successfully gains an owner.
    /// </summary>
    public sealed class OnActorOwnedEvent : ActorEvent
    {
        public OnActorOwnedEvent(IActor actor, bool isLocalOwner = true) : base(actor, isLocalOwner) { }
    }

    /// <summary>
    /// Fired when an actor loses its current owner (becomes neutral or destroyed).
    /// </summary>
    public sealed class OnActorUnownedEvent : ActorEvent
    {
        public OnActorUnownedEvent(IActor actor, bool isLocalOwner = true) : base(actor, isLocalOwner) { }
    }
}