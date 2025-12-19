#nullable enable

namespace GameFramework
{
    /// <summary>
    /// Defines spectating behavior for an object that can be observed by a controller (e.g. camera or player).
    /// </summary>
    public interface ISpectate
    {
        /// <summary>
        /// Gets whether the object is currently being spectated.
        /// </summary>
        bool IsSpectating { get; set; }
        
        /// <summary>
        /// Gets the spectate controller currently observing this object.
        /// </summary>
        ISpectateController? SpectateController { get; set; }
        
        /// <summary>
        /// Get the camera to use when spectating this object.
        /// If you need multiples modes of spectating the same actor, maybe you should consider creating another ISpectate instead, with differents controls, etc.
        /// </summary>
        /// <returns>The spectate camera we should enable when start spectating</returns>
        ICamera GetSpectateCamera();

        /// <summary>
        /// Starts spectating this object using the given controller,
        /// if it is not already being spectated.
        /// </summary>
        /// <param name="controller">The spectate controller to use for spectating.</param>
        void StartSpectating(ISpectateController controller)
        {
            if (IsSpectating)
            {
                return;
            }

            if (controller.CurrentSpectate != this)
            {
                controller.Spectate(this);
            }
            
            SpectateController = controller;

            IsSpectating = true;
            OnStartSpectating();
        }

        /// <summary>
        /// Called when spectating begins. Implement custom behavior here.
        /// </summary>
        void OnStartSpectating();

        /// <summary>
        /// Stops spectating this object,
        /// if it is currently being spectated.
        /// </summary>
        void StopSpectating()
        {
            if (!IsSpectating)
            {
                return;
            }

            IsSpectating = false;
            if (SpectateController != null && SpectateController.CurrentSpectate == this)
            {
                SpectateController.StopSpectating();
            }
            SpectateController = null;
            OnStopSpectating();
        }

        /// <summary>
        /// Called when spectating ends. Implement custom behavior here.
        /// </summary>
        void OnStopSpectating();
    }
}
