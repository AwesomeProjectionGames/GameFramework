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
        /// Gets or sets the pawn currently controlled by this controller.
        /// </summary>
        IPawn? ControlledPawn { get; set; }
        
        /// <summary>
        /// Ourselves as an IController
        /// </summary>
        IController? IActor.Controller => this;
        
        /// <summary>
        /// Get a spectate controller for managing spectating behavior.
        /// Generally, this will be the POVController for every player controller (if split screen) or the full screen POVController.
        /// </summary>
        ISpectateController? SpectateController { get; }

        /// <summary>
        /// Possesses the specified pawn, transferring control to this controller.
        /// </summary>
        /// <param name="pawn">The pawn to possess.</param>
        /// <exception cref="System.ArgumentNullException">Thrown if the pawn is null.</exception>
        /// <exception cref="System.InvalidOperationException">Thrown if the controller is already possessing a pawn.</exception>
        void PossessPawn(IPawn pawn)
        {
            if ((Object)pawn == null)
            {
                Debug.LogError("Cannot possess a null pawn.");
                return;
            }

            if (ControlledPawn != null)
            {
                UnpossessPawn();
            }

            ControlledPawn = pawn;
            pawn.SetOwner(this);
            OnPossess(pawn);
        }

        /// <summary>
        /// Called after a pawn has been successfully possessed.
        /// Override to implement custom logic during possession.
        /// </summary>
        /// <param name="pawn">The pawn that has been possessed.</param>
        void OnPossess(IPawn pawn);
        
        /// <summary>
        /// Unpossesses the currently controlled pawn.
        /// </summary>
        /// <exception cref="System.InvalidOperationException">Thrown if the controller is not possessing any pawn.</exception>
        void UnpossessPawn()
        {
            if (ControlledPawn == null)
            {
                Debug.LogError("Controller is not possessing any pawn.");
                return;
            }

            ControlledPawn.RemoveOwner();
            ControlledPawn = null;
            OnUnpossess();
        }

        /// <summary>
        /// Called after a pawn has been unpossessed.
        /// Override to implement custom logic during unpossession.
        /// </summary>
        void OnUnpossess();
    }
}