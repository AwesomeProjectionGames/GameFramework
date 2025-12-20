using UnityEngine;

namespace GameFramework
{
    /// <summary>
    /// Represents a camera in the game framework (virtual camera or real one).
    /// </summary>
    public interface ICamera
    {
        /// <summary>
        /// Whether the camera is currently active.
        /// We should expect that when we enable a camera, all associated components (like audio listener) will be enabled too (for physical) or call 
        /// </summary>
        public bool IsActive { get; set; }
        public Vector3 Position { get; set; }
        public Quaternion Rotation { get; set; }
        public float FieldOfView { get; set; }
        public float NearClipPlane { get; set; }
        public float FarClipPlane { get; set; }
    }
}