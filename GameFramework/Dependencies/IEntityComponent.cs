namespace GameFramework.Dependencies
{
    /// <summary>
    /// Components that add reusable behavior to an IEntity should implement this interface.
    /// If implemented by a MonoBehaviour, this interface should be considered more restrictive as it imposes that this should be directly on the entity (or a child object).
    /// </summary>
    public interface IEntityComponent
    {
        /// <summary>
        /// The entity that owns this component.
        /// When used with in a Dependency Injection context, this property should be automatically set by the DI container of Entity.
        /// </summary>
        IEntity Entity { get; set ; }
    }
}