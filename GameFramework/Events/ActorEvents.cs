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

        protected ActorEvent(IActor actor)
        {
            Actor = actor;
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
        public OnActorOwnedEvent(IActor actor) : base(actor) { }
    }

    /// <summary>
    /// Fired when an actor loses its current owner (becomes neutral or destroyed).
    /// </summary>
    public sealed class OnActorUnownedEvent : ActorEvent
    {
        public OnActorUnownedEvent(IActor actor) : base(actor) { }
    }
}