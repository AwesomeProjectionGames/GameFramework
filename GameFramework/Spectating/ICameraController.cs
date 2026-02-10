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
        /// It should be a virtual camera that can be copied to the master camera of this controller.
        /// It should copy everything except the viewport rect, which is managed by the controller itself.
        /// </summary>
        ICamera? CurrentCamera { get; }
        
        void TransitionToCamera(ICamera cameraTarget);
        
        /// <summary>
        /// Transition to the specified camera with the given transition settings.
        /// </summary>
        /// <param name="cameraTarget">The target camera to transition to.</param>
        /// <param name="transitionSettings">Settings for the camera transition.</param>
        void TransitionToCamera(ICamera cameraTarget, CameraTransitionSettings transitionSettings);
        
        /// <summary>
        /// The viewport rect of the camera. Values should be between 0 and 1, where (0,0) is the bottom-left corner of the screen and (1,1) is the top-right corner.
        /// </summary>
        Rect ViewPort { get; set; }
    }
}