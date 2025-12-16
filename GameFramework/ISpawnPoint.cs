using System;
using UnityEngine;

namespace GameFramework
{
    /// <summary>
    /// A spawnpoint is a point where an object can be spawned. It can be used by a spawner to spawn objects.
    /// </summary>
    public interface ISpawnPoint
    { 
        /// <summary>
        /// Return true if this spawnpoint is fully available now (not blocked by script or by any other circumstance inherited).
        /// This is the effective availability of the spawnpoint. This can include additional checks like physics, player, etc.
        /// </summary>
        public  bool IsAvailableNow { get; }
        
        /// <summary>
        /// Set the spawnpoint validity. It can be set to unvalid / unauthorized by external scripts to prevent the spawnpoint to be used.
        /// </summary>
        public bool IsValid { get; set;  }
        
        /// <summary>
        /// Select this spawnpoint
        /// </summary>
        /// <returns>The position and rotation to spawn the object</returns>
        public Tuple<Vector3, Quaternion> Select();
    }
}