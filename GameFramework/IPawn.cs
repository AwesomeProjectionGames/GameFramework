#nullable enable

using UnityEngine;

namespace GameFramework
{
    /// <summary>
    /// Pawn is the base class of all actors that can be possessed by players or AI.
    /// </summary>
    public interface IPawn : IActor
    {
        /// <summary>
        /// Make the pawn respawn at one of its spawn points.
        /// </summary>
        void Respawn();

        /// <summary>
        /// Teleport the pawn to a specific location and rotation in the world.
        /// </summary>
        /// <param name="location">The new location in world space.</param>
        /// <param name="rotation">The new rotation in world space.</param>
        void Teleport(Vector3 location, Quaternion rotation);
    }
}