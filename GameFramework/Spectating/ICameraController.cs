#nullable enable

using UnityEngine;

namespace GameFramework
{
    [System.Serializable]
    public struct CameraTransitionSettings
    {
        /// <summary>
        /// Duration of the transition between cameras in seconds.
        /// If zero or negative, the transition is instant.
        /// </summary>
        public float transitionDuration;
        
        /// <summary>
        /// Animation curve that the lerp will follow during the transition.
        /// </summary>
        public AnimationCurve transitionCurve;
    }
    
    /// <summary>
    /// Interface for a camera controller that can transition between different cameras.
    /// </summary>
    public interface ICameraController
    {
        /// <summary>
        /// The currently active camera (or null if no camera is active).
        /// </summary>
        ICamera? CurrentCamera { get; }
        void TransitionToCamera(ICamera cameraTarget);
        /// <summary>
        /// Transition to the specified camera with the given transition settings.
        /// </summary>
        /// <param name="cameraTarget">The target camera to transition to.</param>
        /// <param name="transitionSettings">Settings for the camera transition.</param>
        void TransitionToCamera(ICamera cameraTarget, CameraTransitionSettings transitionSettings);
    }
}