using System.Collections.Generic;
using UnityEngine;

namespace GameFramework
{
    /// <summary>
    /// Interface for objects that have physics properties, such as rigidbodies.
    /// </summary>
    public interface IPhysics
    {
        /// <summary>
        /// The primary rigidbody of the object, which is used for most physics interactions.
        /// </summary>
        Rigidbody MainRigidbody { get; }
        
        /// <summary>
        /// Additional rigidbodies that are part of the object, such as for complex objects with multiple physics parts.
        /// In ragdoll situation, the main rigidbody is generally the spine / hips rigidbody, and the sub rigidbodies are all the other parts of the ragdoll.
        /// </summary>
        IEnumerable<Rigidbody> SubRigidbodies { get; }
        
        /// <summary>
        /// Resets the velocity of the main rigidbody and all sub rigidbodies to zero, effectively stopping all movement and rotation.
        /// </summary>
        void ResetVelocity();
        
        /// <summary>
        /// Sets the linear velocity of the main rigidbody and all sub rigidbodies.
        /// </summary>
        void SetVelocity(Vector3 velocity);

        /// <summary>
        /// Instantly teleports the object to a new position and rotation.
        /// </summary>
        void Teleport(Vector3 position, Quaternion rotation);
        
        /// <summary>
        /// Enables or disables gravity for the main rigidbody and all sub rigidbodies. When disabled, the object will not be affected by gravity and will not fall.
        /// </summary>
        bool GravityEnabled { get; set; }
        
        /// <summary>
        /// Enables or disables physics interactions for the main rigidbody and all sub rigidbodies. When disabled, the object will not be affected by forces, collisions, or other physics interactions.
        /// </summary>
        bool PhysicsEnabled { get; set; }
    }
}