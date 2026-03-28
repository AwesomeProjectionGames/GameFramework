#nullable enable

namespace GameFramework.Events
{
    /// <summary>
    /// Events on the local actor bus should inherit from this class.
    /// Should be used for high-frequency or volatile intra-entity signals.
    /// </summary>
    public abstract class EntityEvent 
    {
        public IEntity Entity { get; }

        protected EntityEvent(IEntity entity)
        {
            Entity = entity;
        }
    }
}