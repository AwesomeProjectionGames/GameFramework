#nullable enable

using GameFramework.Dependencies;
using GameFramework.ObjectManipulation;
using UnityEngine;

namespace GameFramework.Inventory
{
    /// <summary>
    /// Capability interface for any entity that can pick up and drop <see cref="IItemEntityComponent"/> (generally physical objects in the world).
    /// </summary>
    public interface IPicker : IEntityComponent, IDroppable
    {
        /// <summary>
        /// Picks up the target Rigidbody. Drops the current one if already holding something.
        /// </summary>
        void Pickup(IItemEntityComponent targetRb);

        /// <summary>
        /// The <see cref="IItemEntityComponent"/> of the currently held object, or null if nothing is held.
        /// This is the sole source of truth for what is being held.
        /// Use <c>PickedItem.Entity.Transform</c> if you need the held object's transform.
        /// </summary>
        IItemEntityComponent? PickedItem { get; }
    }
}