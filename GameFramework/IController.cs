#nullable enable

using UnityEngine;

namespace GameFramework
{
    /// <summary>
    /// Represents a non-physical entity that can control a pawn. A controller can 
    /// possess or unpossess a pawn to direct its behavior.
    /// </summary>
    public interface IController : IActor
    {
        /// <summary>
        /// The machine owning this controller.
        /// </summary>
        IMachine Machine { get; }
        
        /// <summary>
        /// Gets the display name of this controller / the name of the 'AI' or the real person controlling it.
        /// </summary>
        string Name { get; }
        
        /// <summary>
        /// Gets or sets the pawn currently controlled by this controller.
        /// </summary>
        IActor? ControlledActor { get; set; }
        
        /// <summary>
        /// Ourselves as an IController
        /// </summary>
        IController? IActor.Controller => this;
        
        /// <summary>
        /// Get a spectate controller for managing spectating behavior (UIs, cameras, etc).
        /// Generally, this will be the SpectateController for every player controller (if split screen) or a full screen SpectateController.
        /// </summary>
        ISpectateController? SpectateController { get; }

        /// <summary>
        /// Possesses the specified actor, transferring control to this controller.
        /// </summary>
        /// <param name="actor">The actor to possess.</param>
        /// <exception cref="System.ArgumentNullException">Thrown if the pawn is null.</exception>
        /// <exception cref="System.InvalidOperationException">Thrown if the controller is already possessing a pawn.</exception>
        void PossessActor(IActor actor)
        {
            if ((Object)actor == null)
            {
                Debug.LogError("Cannot possess a null pawn.");
                return;
            }

            if (ControlledActor != null)
            {
                UnpossessActor();
            }

            ControlledActor = actor;
            actor.SetOwner(this);
            OnPossess(actor);
        }

        /// <summary>
        /// Called after a pawn has been successfully possessed.
        /// Override to implement custom logic during possession.
        /// </summary>
        /// <param name="actor">The actor that has been possessed.</param>
        void OnPossess(IActor actor);
        
        /// <summary>
        /// Unpossesses the currently controlled actor.
        /// </summary>
        /// <exception cref="System.InvalidOperationException">Thrown if the controller is not possessing any actor.</exception>
        void UnpossessActor()
        {
            if (ControlledActor == null)
            {
                Debug.LogError("Controller is not possessing any actor.");
                return;
            }

            ControlledActor.RemoveOwner();
            ControlledActor = null;
            OnUnpossess();
        }

        /// <summary>
        /// Called after a actor has been unpossessed.
        /// Override to implement custom logic during unpossession.
        /// </summary>
        void OnUnpossess();
    }
}