namespace GameFramework.GameFramework
{
    /// <summary>
    /// Components that add reusable behavior to an IActor should implement this interface.
    /// If implemented by a MonoBehaviour, this interface should be considered more restrictive as it imposes that this should be directly on the actor / entity (or a child object).
    /// </summary>
    public interface IActorComponent
    {
        IActor GetActor();
    }
}