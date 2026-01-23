using GameFramework.Dependencies;

namespace GameFramework.Interaction {
    /// <summary>
    /// Interface for interactable objects in the interaction system.
    /// </summary>
    public interface IInteractor : IActorComponent
    {
        public void Interact();
    }
}