#nullable enable

using GameFramework.Interaction;

namespace InteractionSystem
{
    /// <summary>
    /// Interface for interactable objects in the interaction system.
    /// </summary>
    public interface IInteractable
    {
        /// <summary>
        /// Determines if the interactable object can be interacted with by the given interactor.
        /// </summary>
        /// <param name="interactor">The interactor attempting to interact with the object.</param>
        /// <returns></returns>
        public bool IsInteractable(IInteractor interactor);
        
        /// <summary>
        /// Text displayed when the interactor is close enough to interact with the object.
        /// Generally used for UI prompts or tooltips.
        /// This should be a short, descriptive string that indicates the action that can be performed (eventually with the object's name / keybind).
        /// This should be localized for different languages.
        /// </summary>
        public string InteractionText { get; }
        
        /// <summary>
        /// A optionnal text (can be null) providing a more detailed description of the interaction (for example, the object's name, or a more detailed description of the action).
        /// </summary>
        public string? InteractionTextDescription { get; }

        
        /// <summary>
        /// True if at least one interactor is currently hovering over this interactable object.
        /// </summary>
        public bool IsAnyHovering { get; }
        
        /// <summary>
        /// Method to handle interaction with the interactor.
        /// </summary>
        /// <param name="interactor">The interactor that is interacting with the object.</param>
        public void Interact(IInteractor interactor);

        /// <summary>
        /// Method called when the interactor hovers over the interactable object.
        /// </summary>
        /// <param name="interactor">The interactor that is hovering over the object.</param>
        public void OnHover(IInteractor interactor);

        /// <summary>
        /// Method called when the interactor stops hovering over the interactable object.
        /// </summary>
        /// <param name="interactor">The interactor that is no longer hovering over the object.</param>
        public void OnHoverQuit(IInteractor interactor);
    }
}