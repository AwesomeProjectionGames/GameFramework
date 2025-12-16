
namespace GameFramework.Interaction {
    /// <summary>
    /// Interface for interactable objects in the interaction system.
    /// </summary>
    public interface IInteractor
    {
        public IPawn PawnOwningThis { get; }
        public void Interact();
    }
}